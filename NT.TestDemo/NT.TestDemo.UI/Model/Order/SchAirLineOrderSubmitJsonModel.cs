using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT.TestDemo.UI.Model.Order
{
    public class SchAirLineOrderSubmitJsonModel
    {

    }

    public class OrderDataJsonModel
    {

        /// <summary>
        ///
        /// </summary>
        public object OrderID { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object PayAmount { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object OrderType { get; set; }
        /// <summary>
        ///710071515
        /// </summary>
        public object MemberID { get; set; }
        /// <summary>
        ///叶李均
        /// </summary>
        public object ContactName { get; set; }
        /// <summary>
        ///NONE
        /// </summary>
        public object ContactAddress { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object ContactPhone { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object ContactZip { get; set; }
        /// <summary>
        ///740916358@qq.com
        /// </summary>
        public object ContactEmail { get; set; }
        /// <summary>
        ///15730313844
        /// </summary>
        public object ContactMobilePhone { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object ContactFoid { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object ContactFoidType { get; set; }
        /// <summary>
        ///1
        /// </summary>
        public object Buyer { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object PayMethod { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object PayMessage { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object Remark { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object IsRedeem { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object IsInvoice { get; set; }
        /// <summary>
        ///EF66EA65A70573CBA3E6F32A4FBA18B9
        /// </summary>
        public object PassKey { get; set; }
    }


    public class AirlineDataJsonModel
    {

        /// <summary>
        ///Single
        /// </summary>
        public object AirlineType { get; set; }
        /// <summary>
        ///False
        /// </summary>
        public object IsFixedCabin { get; set; }
        /// <summary>
        ///class
        /// </summary>
        public List<Sub_RouteListModel> RouteList { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object AVType { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object CardParamModel { get; set; }
        /// <summary>
        ///单程
        /// </summary>
        public object AirlineTypeCN { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object AirlineTypeDigital { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object FareUnit { get; set; }
        /// <summary>
        ///￥
        /// </summary>
        public object FareUnitSymbol { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object InputPsgMode { get; set; }
        /// <summary>
        ///1
        /// </summary>
        public object BuyerType { get; set; }
        /// <summary>
        ///class
        /// </summary>
        public List<Sub_CabinListModel> CabinList { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object IsRedeem { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object FamiliarParamModel { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object IsDirect { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object Flag { get; set; }
        /// <summary>
        ///1177E0B26847F85E852F312819792FAB
        /// </summary>
        public object PassKey { get; set; }
    }
    public class Sub_RouteListModel
    {

        /// <summary>
        ///1
        /// </summary>
        public object RouteIndex { get; set; }
        /// <summary>
        ///单    程
        /// </summary>
        public object RouteName { get; set; }
        /// <summary>
        ///CKG
        /// </summary>
        public object OrgCity { get; set; }
        /// <summary>
        ///PVG
        /// </summary>
        public object DesCity { get; set; }
        /// <summary>
        ///重庆
        /// </summary>
        public object OrgCityName { get; set; }
        /// <summary>
        ///上海浦东
        /// </summary>
        public object DesCityName { get; set; }
        /// <summary>
        ///2015-12-15
        /// </summary>
        public object FlightDate { get; set; }
    }
    public class Sub_CabinListModel
    {

        /// <summary>
        ///2015-12-15 07:25:00
        /// </summary>
        public object FlightDate { get; set; }
        /// <summary>
        ///CKG
        /// </summary>
        public object OrgCity { get; set; }
        /// <summary>
        ///PVG
        /// </summary>
        public object DesCity { get; set; }
        /// <summary>
        ///重庆
        /// </summary>
        public object OrgCityName { get; set; }
        /// <summary>
        ///上海浦东
        /// </summary>
        public object DesCityName { get; set; }
        /// <summary>
        ///3U8971
        /// </summary>
        public object FlightNO { get; set; }
        /// <summary>
        ///2015-12-15 周二
        /// </summary>
        public object TakeOffTimeShow { get; set; }
        /// <summary>
        ///2015-12-15 07:25:00
        /// </summary>
        public object TakeOffTime { get; set; }
        /// <summary>
        ///2015-12-15 09:45:00
        /// </summary>
        public object ArriveTime { get; set; }
        /// <summary>
        ///321
        /// </summary>
        public object PlaneModel { get; set; }
        /// <summary>
        ///50
        /// </summary>
        public object AirTax { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object AddFare { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object AirTaxCH { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object AddFareCH { get; set; }
        /// <summary>
        ///N
        /// </summary>
        public object CabinNO { get; set; }
        /// <summary>
        ///460
        /// </summary>
        public object NewPrice { get; set; }
        /// <summary>
        ///折扣舱
        /// </summary>
        public object CabinName { get; set; }
        /// <summary>
        ///460
        /// </summary>
        public object RealPrice { get; set; }
        /// <summary>
        ///SAZH--
        /// </summary>
        public object SellCode { get; set; }
        /// <summary>
        ///43451-909916-60-N,N-0
        /// </summary>
        public object SaleRuleParam { get; set; }
        /// <summary>
        ///仅退机建费和燃油费，机票款不退,不得自愿改期或升舱,不允许签转
        /// </summary>
        public object CabinRuleDescription { get; set; }
        /// <summary>
        ///提供网上值机,
        /// </summary>
        public object CheckINAndMeal { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object SaleInstruction { get; set; }
        /// <summary>
        ///True
        /// </summary>
        public object IsCheckIn { get; set; }
        /// <summary>
        ///False
        /// </summary>
        public object IsCourtesyBus { get; set; }
        /// <summary>
        ///class
        /// </summary>
        public List<Sub_CabinRuleCHListModel> CabinRuleCHList { get; set; }
        /// <summary>
        ///07:25
        /// </summary>
        public object TakeOffTimeShort { get; set; }
        /// <summary>
        ///09:45
        /// </summary>
        public object ArriveTimeShort { get; set; }
        /// <summary>
        ///1
        /// </summary>
        public object RouteIndex { get; set; }
        /// <summary>
        ///单    程
        /// </summary>
        public object RouteName { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object InputPsgMode { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object FlightIndex { get; set; }
        /// <summary>
        ///False
        /// </summary>
        public object OnlySelf { get; set; }
        /// <summary>
        ///-1
        /// </summary>
        public object UnMemberPrice { get; set; }
        /// <summary>
        ///True
        /// </summary>
        public object IsMileBank { get; set; }
        /// <summary>
        ///N
        /// </summary>
        public object CabinNO_CH { get; set; }
        /// <summary>
        ///460
        /// </summary>
        public object RealPrice_CH { get; set; }
        /// <summary>
        ///仅退机建费和燃油费，机票款不退,不得自愿改期或升舱,不允许签转
        /// </summary>
        public object CabinRuleDescription_CH { get; set; }
        /// <summary>
        ///SAZH--
        /// </summary>
        public object SellCode_CH { get; set; }
        /// <summary>
        ///43451-909916-60-N,N-0
        /// </summary>
        public object SaleRuleParam_CH { get; set; }
        /// <summary>
        ///E79F3DC0A078949C6FF93F54835A6A3F
        /// </summary>
        public object PassKey { get; set; }
    }
    public class Sub_CabinRuleCHListModel
    {

        /// <summary>
        ///F
        /// </summary>
        public object CabinNO { get; set; }
        /// <summary>
        ///FIN--
        /// </summary>
        public object SellCode { get; set; }
        /// <summary>
        ///465
        /// </summary>
        public object CabinRuleID { get; set; }
        /// <summary>
        ///免费退票,免费改期,可升舱至Y舱与F舱,免费签转
        /// </summary>
        public object CabinRuleDescription { get; set; }
        /// <summary>
        ///310
        /// </summary>
        public object NewPrice { get; set; }
        /// <summary>
        ///465-0-0-FIN-0
        /// </summary>
        public object SaleRuleParam { get; set; }
        /// <summary>
        ///310
        /// </summary>
        public object RealPrice { get; set; }
        /// <summary>
        ///2
        /// </summary>
        public object CabinPsgType { get; set; }
        /// <summary>
        ///908A42A6B710FA13597A10CFE8ABC464
        /// </summary>
        public object PassKey { get; set; }
    }

    public class PassengerDataJsonModel
    {
        /// <summary>
        ///张三
        /// </summary>
        public object PsgName { get; set; }
        /// <summary>
        ///AD
        /// </summary>
        public object PsgType { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object PsgAge { get; set; }
        /// <summary>
        ///0
        /// </summary>
        public object FoidType { get; set; }
        /// <summary>
        ///632532198605124568
        /// </summary>
        public object FoidNo { get; set; }
    }

    public class OftenPassengerDataJsonModel
    {

    }
}
