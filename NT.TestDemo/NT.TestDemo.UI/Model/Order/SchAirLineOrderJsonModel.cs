using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT.TestDemo.UI.Model.Order
{
    public class SchAirLineOrderJsonModel
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
        public List<RouteListModel> RouteList { get; set; }

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
        public List<CabinListModel> CabinList { get; set; }

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

    public class RouteListModel
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
        ///2015-12-16
        /// </summary>
        public object FlightDate { get; set; }

        /// <summary>
        ///Single
        /// </summary>
        public object AirlineType { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object AVType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object CardFlag { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object Flag { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object BuyerType { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public object IsFixedCabin { get; set; }

        /// <summary>
        ///1177E0B26847F85E852F312819792FAB
        /// </summary>
        public object PassKey { get; set; }
    }

    public class CabinListModel
    {

        /// <summary>
        ///0
        /// </summary>
        public object InputPsgMode { get; set; }

        /// <summary>
        ///单    程
        /// </summary>
        public object RouteName { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object RouteIndex { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<SRI_CabinListModel> CabinRuleCHList { get; set; }

        /// <summary>
        ///2015-12-16 周三
        /// </summary>
        public object FlightDateText { get; set; }

        /// <summary>
        ///12/15/2015 16:00:00
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
        ///http://125.69.90.49:6665/SCAL.WebMaster/FileUPload/GGImg/banner2.jpg
        /// </summary>
        public object PlaneModelURL { get; set; }

        /// <summary>
        ///机型320(大)
        /// </summary>
        public object PlaneModelName { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object FlightIndex { get; set; }

        /// <summary>
        ///3U8971
        /// </summary>
        public object FlightNO { get; set; }

        /// <summary>
        ///07:25
        /// </summary>
        public object TakeOffTimeShort { get; set; }

        /// <summary>
        ///09:45
        /// </summary>
        public object ArriveTimeShort { get; set; }

        /// <summary>
        ///12/15/2015 23:25:00
        /// </summary>
        public object TakeOffTime { get; set; }

        /// <summary>
        ///12/16/2015 01:45:00
        /// </summary>
        public object ArriveTime { get; set; }

        /// <summary>
        ///320
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
        ///3.0折
        /// </summary>
        public object CabinRebate { get; set; }

        /// <summary>
        ///898C1DAFBA25E45BDA7D25074ABD23A4
        /// </summary>
        public object PassKey { get; set; }

        /// <summary>
        ///104
        /// </summary>
        public object CabinIndex { get; set; }

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
        ///True
        /// </summary>
        public object IsMileBank { get; set; }

        /// <summary>
        ///-1
        /// </summary>
        public object UnMemberPrice { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public object OnlySelf { get; set; }
    }

    public class CabinRuleCHListModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object CabinFlag { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object CabinIndex { get; set; }

        /// <summary>
        ///F
        /// </summary>
        public object CabinNO { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object CabinName { get; set; }

        /// <summary>
        ///2
        /// </summary>
        public object CabinPsgType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object CabinRebate { get; set; }

        /// <summary>
        ///免费退票,免费改期,可升舱至Y舱与F舱,免费签转
        /// </summary>
        public object CabinRuleDescription { get; set; }

        /// <summary>
        ///465
        /// </summary>
        public object CabinRuleID { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object CategoryID { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object CheckINAndMeal { get; set; }

        /// <summary>
        ///FIN
        /// </summary>
        public object FareBasis { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<HandingChargeModelModel> HandingChargeModel { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object InputPsgMode { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public object IsCheckIn { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public object IsCourtesyBus { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public object IsMileBank { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public object IsMultiPackPrice { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public object IsSA { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public object IsSpecialOffer { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public object IsT2 { get; set; }

        /// <summary>
        ///{}
        /// </summary>
        public object MultiMorePrice { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object NewAmount { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object NewMile { get; set; }

        /// <summary>
        ///310
        /// </summary>
        public object NewPrice { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object NewPriceText { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object OldAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object OldCabinNo { get; set; }

        /// <summary>
        ///310
        /// </summary>
        public object OldPrice { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public object OnlySelf { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object OperateTypePrice { get; set; }

        /// <summary>
        ///908A42A6B710FA13597A10CFE8ABC464
        /// </summary>
        public object PassKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object PriceIconName { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object PriceUnit { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object PromotionCardFavorID { get; set; }

        /// <summary>
        ///310
        /// </summary>
        public object RealPrice { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object RealPriceText { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object SaleInstruction { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object SaleRuleID { get; set; }

        /// <summary>
        ///465-0-0-FIN-0
        /// </summary>
        public object SaleRuleParam { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object Score { get; set; }

        /// <summary>
        ///FIN--
        /// </summary>
        public object SellCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object TicketID { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object UnMemberPrice { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object UnMemberPriceText { get; set; }
    }
    
}
