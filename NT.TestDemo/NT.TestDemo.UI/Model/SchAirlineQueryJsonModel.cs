using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NT.TestDemo.UI.Model
{
    public class SchAirlineQueryJsonModel
    {
        //{"AirlineType":"Single","IsFixedCabin":false,"RouteList":[{"RouteIndex":1,"RouteName":"单    程","OrgCity":"CKG","DesCity":"PVG","OrgCityName":"重庆","DesCityName":"上海浦东","FlightDate":"2015-12-07"}],"AVType":0}
        //{"AirlineType":"Single","IsFixedCabin":false,"RouteList":[{"RouteIndex":1,"RouteName":"单    程","OrgCity":"CKG","DesCity":"PVG","OrgCityName":"重庆","DesCityName":"上海浦东","FlightDate":"2015-12-14"}],"AVType":0}"
        /// <summary>
        /// 类型
        /// <example>Single</example>
        /// </summary>
        public String AirlineType { get; set; }
        /// <summary>
        /// 
        /// <example>false</example>
        /// </summary>
        public Boolean IsFixedCabin { get; set; }
        public List<SchAirlineQueryJsonRouteModel> RouteList { get; set; }
        /// <summary>
        /// 
        /// <example>0</example>
        /// </summary>
        public Int32 AVType { get; set; }

        public String CardFlag { get; set; }
        public String Flag { get; set; }
        public String BuyerType { get; set; }
        public String PassKey { get; set; }
        public override string ToString()
        {
            //RouteIndex	1
            //RouteName	单    程
            //OrgCity	CKG
            //DesCity	DLC
            //OrgCityName	重庆
            //DesCityName	大连
            //FlightDate	2015-12-13
            //AirlineType	Single
            //AVType	0
            //CardFlag	
            //Flag	
            //BuyerType	0
            //IsFixedCabin	false
            //PassKey	3807208448F077E4FBC633AAA6AB2320
            //StringBuilder builder = new StringBuilder();
            //builder.AppendFormat("RouteIndex={0}",RouteList.RouteIndex);
            //builder.AppendFormat("&RouteName={0}", HttpUtility.UrlEncode(RouteList.RouteName));
            //builder.AppendFormat("&OrgCity={0}", RouteList.OrgCity);
            //builder.AppendFormat("&DesCity={0}", RouteList.DesCity);
            //builder.AppendFormat("&OrgCityName={0}", HttpUtility.UrlEncode(RouteList.OrgCityName));
            //builder.AppendFormat("&DesCityName={0}", HttpUtility.UrlEncode(RouteList.DesCityName));
            //builder.AppendFormat("&FlightDate={0}", RouteList.FlightDate);
            //builder.AppendFormat("&AirlineType={0}", AirlineType);
            //builder.AppendFormat("&AVType={0}", AVType);
            //builder.AppendFormat("&CardFlag={0}", CardFlag);
            //builder.AppendFormat("&Flag={0}", Flag);
            //builder.AppendFormat("&BuyerType={0}", BuyerType);
            //builder.AppendFormat("&IsFixedCabin={0}", IsFixedCabin.ToString().ToLower());
            //builder.AppendFormat("&PassKey={0}", PassKey);
            //return builder.ToString();

            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("RouteIndex={0}", RouteList[0].RouteIndex);
            builder.AppendFormat("&RouteName={0}", RouteList[0].RouteName);
            builder.AppendFormat("&OrgCity={0}", RouteList[0].OrgCity);
            builder.AppendFormat("&DesCity={0}", RouteList[0].DesCity);
            builder.AppendFormat("&OrgCityName={0}", RouteList[0].OrgCityName);
            builder.AppendFormat("&DesCityName={0}", RouteList[0].DesCityName);
            builder.AppendFormat("&FlightDate={0}", RouteList[0].FlightDate);
            builder.AppendFormat("&AirlineType={0}", AirlineType);
            builder.AppendFormat("&AVType={0}", AVType);
            builder.AppendFormat("&CardFlag={0}", CardFlag);
            builder.AppendFormat("&Flag={0}", Flag);
            builder.AppendFormat("&BuyerType={0}", BuyerType);
            builder.AppendFormat("&IsFixedCabin={0}", IsFixedCabin.ToString().ToLower());
            builder.AppendFormat("&PassKey={0}", PassKey);
            return builder.ToString();
        }
    }

    public class SchAirlineQueryJsonRouteModel
    {
        //"RouteList":[{"RouteIndex":1,"RouteName":"单    程","OrgCity":"CKG","DesCity":"PVG","OrgCityName":"重庆","DesCityName":"上海浦东","FlightDate":"2015-12-07"}]
        /// <summary>
        /// 
        /// <example>1</example>
        /// </summary>
        public Int32 RouteIndex { get; set; }
        /// <summary>
        /// 行程
        /// <example>单    程</example>
        /// <remarks>注意中间的空格</remarks>
        /// </summary>
        public String RouteName { get; set; }
        /// <summary>
        /// 出发城市
        /// <example>CKG</example>
        /// </summary>
        public String OrgCity { get; set; }
        /// <summary>
        /// 达到城市
        /// <example>PVG</example>
        /// </summary>
        public String DesCity { get; set; }
        /// <summary>
        /// 出发城市
        /// <example>重庆</example>
        /// </summary>
        public String OrgCityName { get; set; }
        /// <summary>
        /// 达到城市
        /// <example>北京</example>
        /// </summary>
        public String DesCityName { get; set; }
        /// <summary>
        /// 出发日期
        /// <example>2015-12-07</example>
        /// </summary>
        public String FlightDate { get; set; }
    }
}
