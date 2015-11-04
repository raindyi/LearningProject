using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using log4net;
using Newtonsoft.Json;
using NT.TestDemo.Common.Helper;
using NT.TestDemo.Common.Model;
using NT.TestDemo.Common.WebClientHelper;
using NT.TestDemo.Core.Events;
using NT.TestDemo.Core.Model;
using NT.TestDemo.UI.Model;

namespace NT.TestDemo.UI.Lib
{
    public class SchAirlineWBMHandler
    {
        private ILog _log = LogManager.GetLogger(typeof(SchAirlineWBMHandler));
        private String _passkey = "";
        private WebBrowser _wBrowser;

        public event LoginProcessEventHandler LoginEvnet;
        private LoginProcessModel _loginModel;
        public LoginProcessModel LoginModel
        {
            get { return _loginModel; }
            set { _loginModel = value; }
        }

        protected String CookieInformation;
        public SchAirlineWBMHandler()
        {
            
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
                if (_loginModel.ContainsCook)
                {
                    CookieInformation = GetCookieString(e.Url.AbsoluteUri);
                    _wBrowser.DocumentCompleted -= _webBrowser_DocumentCompleted;
                    result.Successed = true;
                    OnLoginHandler(result);
                }
            }
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
            var result= client.DownloadString("http://www.scal.com.cn/Web/Base/isVali");
            lists.Add(result);
            _log.Debug(model.ToString());
            
            client = InitClient();
            client.Headers.Add(HttpRequestHeader.Referer, "http://www.scal.com.cn/Web/ETicket/AirlineList");
            var rdata = client.UploadData(queryUri, "POST", Encoding.UTF8.GetBytes(model.ToString()));
             String resultheml = Encoding.UTF8.GetString(rdata);
            try
            {
                SchAilrLineJsonModel informationModel = new SchAilrLineJsonModel();
                informationModel = JsonConvert.DeserializeObject<SchAilrLineJsonModel>(resultheml);
                informationModel.AirlineListJSONModel = JsonConvert.DeserializeObject<AirlineListJSONModel>(informationModel.AirlineListJSON);
            }
            catch (Exception ex)
            {
                _log.Debug("AirLineInformationModel to model", ex);
            }
            //_log.Debug(resultheml);
            return lists;
        }

        private void GetPassKey(SchAirlineQueryJsonModel model)
        {
            WebClient client = InitClient();
            //http://www.scal.com.cn/Web/Reservation?type=single
            var result = client.DownloadString("http://www.scal.com.cn/Web/Base/isVali");
            client = InitClient();
            String para = "AirlineParamJSON=" + "{\"AirlineType\":\"Single\",\"IsFixedCabin\":false,\"RouteList\":[{\"RouteIndex\":1,\"RouteName\":\"单    程\",\"OrgCity\":\"CKG\",\"DesCity\":\"PVG\",\"OrgCityName\":\"重庆\",\"DesCityName\":\"上海浦东\",\"FlightDate\":\"2015-12-14\"}],\"AVType\":0}";
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
