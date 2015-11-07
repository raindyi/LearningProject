using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using log4net;
using log4net.Layout.Pattern;
using log4net.Util.PatternStringConverters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NT.TestDemo.Common.Helper;
using NT.TestDemo.Common.Model;
using NT.TestDemo.Common.WebClientHelper;
using NT.TestDemo.Core.Events;
using NT.TestDemo.Core.Model;
using NT.TestDemo.UI.Model;
using NT.TestDemo.UI.Model.Order;

namespace NT.TestDemo.UI.Lib
{
    public class SchAirlineWBMHandler
    {
        private ILog _log = LogManager.GetLogger(typeof(SchAirlineWBMHandler));
        private String _passkey = "";
        private WebBrowser _wBrowser;
        private SchAilrLineJsonModel _jsonModel = null;

        public event LoginProcessEventHandler LoginEvnet;
        private LoginProcessModel _loginModel;
        private Int32 _cnt = 0;
        public LoginProcessModel LoginModel
        {
            get { return _loginModel; }
            set { _loginModel = value; }
        }

        protected String CookieInformation;
        public MemberModel Member = null;
        public SchAirlineWBMHandler()
        {
            DataTable dt=new DataTable();
            dt.Columns[0].DefaultValue = "";
        } 

        public SchAirlineWBMHandler(WebBrowser browser = null)
        {
            _wBrowser = browser ?? new WebBrowser();
            if (_wBrowser != null)
            {
                _wBrowser.DocumentCompleted += _webBrowser_DocumentCompleted;
            }
        }
        
        #region Function

        protected void OnLoginHandler(HandlingResult loginResult)
        {
            if (LoginEvnet != null)
            {
                LoginEvnet(loginResult);
            }
        }

        public void Login()
        {
            if (_loginModel != null)
            {
                _wBrowser.Navigate(_loginModel.LoginUrl);
            }
            else
            {
                //TODO message
            }
        }
        
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool InternetGetCookieEx(string pchUrl, string pchCookieName, StringBuilder pchCookieData, ref int pcchCookieData, int dwFlags, string lpReserved);
        private string GetCookieString(string url)
        {
            // Determine the size of the cookie          
            int datasize = 5000;
            StringBuilder cookieData = new StringBuilder(datasize);
            if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x00002000, null))
            {
                if (datasize < 0)
                    return null;
                // Allocate stringbuilder large enough to hold the cookie        
                cookieData = new StringBuilder(datasize);
                if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x00002000, null))
                    return null;
            }
            return cookieData.ToString();
        }
        #endregion
        #region Event

        private void _webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HandlingResult result = new HandlingResult();
            result.Successed = false;
            if (e.Url.AbsoluteUri.Replace("//","/").Replace("http:","http:/").Contains("http://www.scal.com.cn/Web/Html/Home/Special.html"))
            {
                _wBrowser.Navigate(new Uri("http://www.scal.com.cn/Web/AirUser/Info"));
            }
            if (e.Url.AbsoluteUri.Contains("http://www.scal.com.cn/Web/AirUser/Info"))
            {
                //TODO get member infor
                GetMemberInfo();
                if (_loginModel.ContainsCook)
                {
                    CookieInformation = GetCookieString(e.Url.AbsoluteUri);
                    _wBrowser.DocumentCompleted -= _webBrowser_DocumentCompleted;
                    result.Successed = true;
                    OnLoginHandler(result);
                }
            }
        }

        private void GetMemberInfo()
        {

        }

        #endregion
        public List<String> Query(Uri queryUri)
        {
            WebClient client=new WebClient();
            client.Headers.Add(HttpRequestHeader.Accept, "application/x-ms-application, image/jpeg, application/xaml+xml, image/gif, image/pjpeg, application/x-ms-xbap, */*");
            client.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate, lzma");
            client.Headers.Add(HttpRequestHeader.AcceptLanguage, "zh-CN");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET4.0C; .NET4.0E)");
            client.Headers.Add(HttpRequestHeader.Cookie, CookieInformation);
            client.Encoding = Encoding.UTF8;
            
            var dldata = client.DownloadData(queryUri);
            String resultheml = Encoding.GetEncoding("utf-8").GetString(dldata);
            Int32 i = resultheml.IndexOf("PassKey", 0) + "PassKey".Length + 4;
            Int32 j = resultheml.IndexOf("}", i) - 2;
            String pk = resultheml.Substring(i, j - i);
            List<String> lists=new List<string>();
            _log.Debug(pk);
            return lists;
            //RouteIndex=1&RouteName=%E5%8D%95%26nbsp%3B%26nbsp%3B%26nbsp%3B%26nbsp%3B%E7%A8%8B&OrgCity=CKG&DesCity=PEK&OrgCityName=%E9%87%8D%E5%BA%86&DesCityName=%E5%8C%97%E4%BA%AC&FlightDate=2015-10-30&AirlineType=Single&AVType=0&CardFlag=&Flag=&BuyerType=1&IsFixedCabin=false&PassKey=1177E0B26847F85E852F312819792FAB
        }

        public List<String> QuerySingle(Uri queryUri,SchAirlineQueryJsonModel model)
        {
            if (String.IsNullOrEmpty(_passkey))
            {
                GetPassKey(model);
            }
            model.PassKey = _passkey;
            List<String> lists = new List<string>();
            WebClient client = InitClient();
            client.Headers.Add(HttpRequestHeader.Referer, "http://www.scal.com.cn/Web/ETicket/AirlineList");
            Validation();
            _log.Debug(model.ToString());
            client = InitClient();
            client.Headers.Add(HttpRequestHeader.Referer, "http://www.scal.com.cn/Web/ETicket/AirlineList");
            var rdata = client.UploadData(queryUri, "POST", Encoding.UTF8.GetBytes(model.ToString()));
             String resultheml = Encoding.UTF8.GetString(rdata);
            try
            {
                if (resultheml.Contains("系统繁忙"))
                {
                    return QuerySingle(queryUri, model);
                }
                else if (resultheml.Contains("查询当日无航班"))
                {
                    if (_cnt < 3)
                    {
                        return QuerySingle(queryUri, model);
                        _cnt++;
                    }
                    else
                    {
                        _cnt = 0;
                        return lists;
                    }
                }
                else
                {
                    _jsonModel = JsonConvert.DeserializeObject<SchAilrLineJsonModel>(resultheml);
                    _jsonModel.AirlineListJSONModel =
                        JsonConvert.DeserializeObject<AirlineListJSONModel>(_jsonModel.AirlineListJSON);

                    JObject jobj=(JObject) JsonConvert.DeserializeObject(resultheml);
                }
            }
            catch (Exception ex)
            {
                _log.Debug("AirLineInformationModel to model", ex);
            }
            //_log.Debug(resultheml);
            return lists;
        }

        private void OrderSingle()
        {
            //orderType:Single
            #region create para

            if (_jsonModel.AirlineListJSONModel.SRI_FlightList != null &&
                _jsonModel.AirlineListJSONModel.SRI_FlightList.Count > 0)
            {
                SchAirLineOrderJsonModel model = new SchAirLineOrderJsonModel()
                {
                    AVType = 0,
                    AirlineType = "Single",
                    AirlineTypeCN = "单程",
                    AirlineTypeDigital = "",
                    BuyerType = "1",
                    CardParamModel = null,
                    FamiliarParamModel = null,
                    FareUnit = 0,
                    FareUnitSymbol = "￥",
                    Flag = null,
                    InputPsgMode = "0",
                    IsDirect = 0,
                    IsFixedCabin = false,
                    IsRedeem = 0,
                    PassKey = _passkey,
                };
                model.RouteList = new List<RouteListModel>();
                model.RouteList.Add(new RouteListModel()
                {
                    AVType = 0,
                    AirlineType = "Single",
                    BuyerType = "1",
                    CardFlag = "",
                    DesCity = _jsonModel.AirlineListJSONModel.DesCity,
                    DesCityName = _jsonModel.AirlineListJSONModel.DesCityName,
                    Flag = null,
                    FlightDate = _jsonModel.AirlineListJSONModel.FlightDate.ToString("yyyy-MM-dd"),
                    IsFixedCabin = false,
                    OrgCity = _jsonModel.AirlineListJSONModel.OrgCity,
                    OrgCityName = _jsonModel.AirlineListJSONModel.OrgCityName,
                    PassKey = _passkey,
                    RouteIndex = 1,
                    RouteName = _jsonModel.AirlineListJSONModel.RouteName
                });
                model.CabinList = new List<CabinListModel>();
                SRI_FlightListModel flightListModel = _jsonModel.AirlineListJSONModel.SRI_FlightList[0];
                model.CabinList.Add(new CabinListModel()
                {
                    AddFare = flightListModel.AddFare,
                    AddFareCH = flightListModel.AddFareCH,
                    AirTax = flightListModel.AirTax,
                    AirTaxCH = flightListModel.AirTaxCH,
                    ArriveTime = flightListModel.ArriveTime,
                    ArriveTimeShort = flightListModel.ArriveTimeShort,
                    CabinIndex = flightListModel.CabinModel.CabinIndex,
                    CabinNO = flightListModel.CabinModel.CabinNO,
                    CabinName = flightListModel.CabinModel.CabinName,
                    CabinRebate = flightListModel.CabinModel.CabinRebate,
                    CabinRuleDescription = flightListModel.CabinModel.CabinRuleDescription,
                    CheckINAndMeal = flightListModel.CabinModel.CheckINAndMeal,
                    DesCity = _jsonModel.AirlineListJSONModel.DesCity,
                    DesCityName = _jsonModel.AirlineListJSONModel.DesCityName,
                    FlightDate = _jsonModel.AirlineListJSONModel.FlightDate,
                    FlightDateText = _jsonModel.AirlineListJSONModel.FlightDateText,
                    FlightIndex = flightListModel.FlightIndex,
                    FlightNO = flightListModel.FlightNo,
                    InputPsgMode = _jsonModel.AirlineListJSONModel.InputPsgMode,
                    IsCheckIn = flightListModel.CabinModel.IsCheckIn,
                    IsCourtesyBus = flightListModel.CabinModel.IsCourtesyBus,
                    IsMileBank = flightListModel.CabinModel.IsMileBank,
                    NewPrice = flightListModel.CabinModel.NewPrice,
                    OnlySelf = flightListModel.CabinModel.OnlySelf,
                    OrgCity = _jsonModel.AirlineListJSONModel.OrgCity,
                    OrgCityName = _jsonModel.AirlineListJSONModel.OrgCityName,
                    PassKey = flightListModel.CabinModel.PassKey,
                    PlaneModel = flightListModel.PlaneModel,
                    PlaneModelName = flightListModel.PlaneModelName,
                    PlaneModelURL = flightListModel.PlaneModelURL,
                    RealPrice = flightListModel.CabinModel.RealPrice,
                    RouteIndex = "1",
                    RouteName = _jsonModel.AirlineListJSONModel.RouteName,
                    SaleInstruction = flightListModel.CabinModel.SaleInstruction,
                    SaleRuleParam = flightListModel.CabinModel.SaleRuleParam,
                    SellCode = flightListModel.CabinModel.SellCode,
                    TakeOffTime = flightListModel.TakeOffTime,
                    TakeOffTimeShort = flightListModel.TakeOffTimeShort,
                    UnMemberPrice = flightListModel.CabinModel.UnMemberPrice,
                    CabinRuleCHList = flightListModel.SRI_CabinList
                });

                #endregion

                String para = String.Format("AirlineParamJSON={0}", JsonConvert.SerializeObject(model));
                WebClient client = InitClient();
                client.Headers.Add(HttpRequestHeader.Referer, "http://www.scal.com.cn/Web/ETicket/AirlineList");
                Validation();
                var resultdata = client.UploadData("http://www.scal.com.cn/Web/ETicket/BookingOrder", "POST",
                    Encoding.UTF8.GetBytes(para));
                String result = Encoding.UTF8.GetString(resultdata);
            }
        }

        private void OrderSingleSubmit(SchAirLineOrderJsonModel order)
        {
            #region para
            OrderDataJsonModel orderData = new OrderDataJsonModel()
            {
                ContactAddress = Member.Address,
                ContactEmail = Member.Emial,
                ContactFoid = null,
                ContactFoidType = "0",
                ContactMobilePhone = Member.CellPhone,
                ContactName = Member.Name,
                ContactPhone = null,
                ContactZip = null,
                Buyer = "1",
                IsInvoice = "0",
                IsRedeem = "0",
                MemberID = Member.Id,
                OrderID = null,
                OrderType = "0",
                PassKey = "",
                PayAmount = null,
                PayMessage = "",
                PayMethod = "0",
                Remark = null
            };
            List<PassengerDataJsonModel> passengerDatas = new List<PassengerDataJsonModel>()
            {
                new PassengerDataJsonModel()
                {
                    FoidNo = "0",
                    FoidType = "0",
                    PsgAge = "0",
                    PsgName = "张三",
                    PsgType = "AD"
                }
            };
            AirlineDataJsonModel airlineData = new AirlineDataJsonModel()
            {
                AVType = order.AVType,
                AirlineType = order.AirlineType,
                AirlineTypeCN = order.AirlineTypeCN,
                AirlineTypeDigital = order.AirlineTypeDigital,
                BuyerType = order.BuyerType,
                CardParamModel = order.CardParamModel,
                FamiliarParamModel = order.FamiliarParamModel,
                FareUnit = order.FareUnit,
                FareUnitSymbol = order.FareUnitSymbol,
                Flag = order.Flag,
                InputPsgMode = order.InputPsgMode,
                IsDirect = order.IsDirect,
                IsFixedCabin = order.IsFixedCabin,
                IsRedeem = order.IsRedeem,
                PassKey = order.PassKey
            };
            airlineData.RouteList = ConvertTOSubOrder(order.RouteList);
            airlineData.CabinList = ConvertTOSubOrder(order.CabinList);
            #endregion
            StringBuilder paraBuilder = new StringBuilder();
            paraBuilder.AppendFormat("OrderData={0}", JsonConvert.SerializeObject(orderData));
            paraBuilder.AppendFormat("&AirlineData={0}", JsonConvert.SerializeObject(airlineData));
            paraBuilder.AppendFormat("&PassengerData={0}", JsonConvert.SerializeObject(passengerDatas));
            paraBuilder.Append("&OftenPassengerData=[]");
            paraBuilder.Append("&MemberData={}");
            paraBuilder.Append("&IsBuyInsurance=0");
            paraBuilder.Append("&BankPreferentialData=[]");
            paraBuilder.Append("&VerificationCode=");
            WebClient client = InitClient();
            client.Headers.Add(HttpRequestHeader.Referer, "http://www.scal.com.cn/Web/ETicket/BookingOrder");
            OrderValidation();
            var resultdata = client.UploadData("http://www.scal.com.cn/Web/ETicket/SubmitOrder", "POST", Encoding.UTF8.GetBytes(paraBuilder.ToString()));
            String result = Encoding.UTF8.GetString(resultdata);

        }

        private List<Sub_RouteListModel> ConvertTOSubOrder(List<RouteListModel> routeList )
        {
            List<Sub_RouteListModel> list=new List<Sub_RouteListModel>();

            foreach (RouteListModel model in routeList)
            {
                Sub_RouteListModel submodel=new Sub_RouteListModel();
                foreach (PropertyInfo property in submodel.GetType().GetProperties() )
                {
                    try
                    {
                        property.SetValue(submodel,
                            model.GetType()
                                .GetProperty(property.Name, BindingFlags.Public | BindingFlags.Instance)
                                .GetValue(model));
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
            }
            return list;
        }

        private List<Sub_CabinListModel> ConvertTOSubOrder(List<CabinListModel> cabinList )
        {
            List<Sub_CabinListModel> list = new List<Sub_CabinListModel>();

            foreach (CabinListModel model in cabinList)
            {
                Sub_CabinListModel submodel = new Sub_CabinListModel();
                foreach (PropertyInfo property in submodel.GetType().GetProperties())
                {
                    if (property.PropertyType.Equals(typeof (System.Collections.Generic.List<>)))
                    {
                        continue;
                    }
                    else
                    {
                        try
                        {
                            property.SetValue(submodel,
                                model.GetType()
                                    .GetProperty(property.Name, BindingFlags.Public | BindingFlags.Instance)
                                    .GetValue(model));
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }
                    }
                }
                submodel.CabinRuleCHList = ConvertTOSubOrder(model.CabinRuleCHList);
            }
            
            return list;
        }

        private List<Sub_CabinRuleCHListModel> ConvertTOSubOrder(List<SRI_CabinListModel> cabinRuleChList)
        {
            List<Sub_CabinRuleCHListModel> list = new List<Sub_CabinRuleCHListModel>();

            foreach (SRI_CabinListModel model in cabinRuleChList)
            {
                Sub_CabinRuleCHListModel submodel = new Sub_CabinRuleCHListModel();
                foreach (PropertyInfo property in submodel.GetType().GetProperties())
                {
                    try
                    {
                        property.SetValue(submodel,
                            model.GetType()
                                .GetProperty(property.Name, BindingFlags.Public | BindingFlags.Instance)
                                .GetValue(model));
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
            }
            return list;
        }

        private void Validation()
        {
            //POST http://www.scal.com.cn/Web/Base/isVali
            WebClient client = InitClient();
            var result = client.DownloadString("http://www.scal.com.cn/Web/Base/isVali");
        }

        private void OrderValidation()
        {
            //POST http://www.scal.com.cn/Web/ETicket/BookingOrderCheck
            WebClient client = InitClient();
            String para = "MobilePhone=";
            String result= client.UploadString(new Uri("http://www.scal.com.cn/Web/ETicket/BookingOrderCheck"), "POST", para);
        }

        private void GetPassKey(SchAirlineQueryJsonModel model)
        {
            WebClient client = InitClient();
            //http://www.scal.com.cn/Web/Reservation?type=single
            var result = client.DownloadString("http://www.scal.com.cn/Web/Base/isVali");
            client = InitClient();
            String para = "AirlineParamJSON=" + "{\"AirlineType\":\"Single\",\"IsFixedCabin\":false,\"RouteList\":[{\"RouteIndex\":1,\"RouteName\":\"单    程\",\"OrgCity\":\"CKG\",\"DesCity\":\"PVG\",\"OrgCityName\":\"重庆\",\"DesCityName\":\"上海浦东\",\"FlightDate\":\"2015-12-14\"}],\"AVType\":0}";
            String parajson = "AirlineParamJSON" + JsonConvert.SerializeObject(model);
            _log.Debug(para);
            _log.Debug(parajson);
            client.Headers.Add(HttpRequestHeader.Referer, "http://www.scal.com.cn/Web");
            var rdata = client.UploadData("http://www.scal.com.cn/Web/ETicket/AirlineList", "POST", Encoding.UTF8.GetBytes(para));
            String resultheml = Encoding.GetEncoding("utf-8").GetString(rdata);
            Int32 i = resultheml.IndexOf("PassKey", 0) + "PassKey".Length + 3;
            Int32 j = resultheml.IndexOf("}", i) - 1;
            String pk = resultheml.Substring(i, j - i);
            _passkey = pk;
            _log.Debug(String.Format("PassKey::{0}",pk));
        }
        private WebClient InitClient()
        {
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.Accept, "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET4.0C; .NET4.0E)");
            client.Headers.Add(HttpRequestHeader.Cookie, CookieInformation);
            client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
            client.Encoding = Encoding.UTF8;
            return client;
        }
    }
}
