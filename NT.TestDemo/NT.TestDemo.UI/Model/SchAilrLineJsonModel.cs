using System;
using System.Collections.Generic;

namespace NT.TestDemo.UI.Model
{
    public class SchAilrLineJsonModel
    {

        /// <summary>
        ///True
        /// </summary>
        public object Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object Message { get; set; }

        /// <summary>
        ///True
        /// </summary>
        public object IsDirect { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public AirlineListJSONModel AirlineListJSONModel { get; set; }
        public String AirlineListJSON { get; set; }
    }

    public class AirlineListJSONModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object AirlineFlag { get; set; }

        /// <summary>
        ///<CabinRuleCH><Item><CabinNO>Y</CabinNO> <SellCode>YCH--</SellCode><CabinRuleID>100223</CabinRuleID><CabinRuleDescription>退票收取10%手续费,免费改期,可升舱至Y舱与F舱,允许签转</CabinRuleDescription><NewPrice>780</NewPrice><RealPrice>780</RealPrice><SaleRuleParam>100223-0-0-YCH-0</SaleRuleParam></Item><Item><CabinNO>F</CabinNO> <SellCode>FCH--</SellCode><CabinRuleID>100223</CabinRuleID><CabinRuleDescription>退票收取10%手续费,免费改期,可升舱至Y舱与F舱,允许签转</CabinRuleDescription><NewPrice>1550</NewPrice><RealPrice>1550</RealPrice><SaleRuleParam>100223-0-0-FCH-0</SaleRuleParam></Item></CabinRuleCH><CabinRuleIN><Item><CabinNO>F</CabinNO> <SellCode>FIN--</SellCode><CabinRuleID>465</CabinRuleID><CabinRuleDescription>免费退票,免费改期,可升舱至Y舱与F舱,免费签转</CabinRuleDescription><NewPrice>310</NewPrice><RealPrice>310</RealPrice><SaleRuleParam></SaleRuleParam></Item><Item><CabinNO>Y</CabinNO> <SellCode>YIN--</SellCode><CabinRuleID>465</CabinRuleID><CabinRuleDescription>免费退票,免费改期,可升舱至Y舱与F舱,免费签转</CabinRuleDescription><NewPrice>160</NewPrice><RealPrice>160</RealPrice><SaleRuleParam></SaleRuleParam></Item></CabinRuleIN>
        /// </summary>
        public String DefaultCabinRuleForCH { get; set; }

        /// <summary>
        ///PVG
        /// </summary>
        public String DesCity { get; set; }

        /// <summary>
        ///上海浦东
        /// </summary>
        public String DesCityName { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String Error { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object FareUnit { get; set; }

        /// <summary>
        ///￥
        /// </summary>
        public String FareUnitSymbol { get; set; }

        /// <summary>
        ///12/13/2015 16:00:00
        /// </summary>
        public DateTime FlightDate { get; set; }

        /// <summary>
        ///2015-12-14 周一
        /// </summary>
        public String FlightDateText { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object InputPsgMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object LowestDiscount { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object OrderType { get; set; }

        /// <summary>
        ///CKG
        /// </summary>
        public String OrgCity { get; set; }

        /// <summary>
        ///重庆
        /// </summary>
        public String OrgCityName { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String PsgType { get; set; }

        /// <summary>
        ///单    程
        /// </summary>
        public String RouteName { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public SRI_AirlineBaseModelModel SRI_AirlineBaseModel { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<SRI_FlightListModel> SRI_FlightList { get; set; }

        /// <summary>
        ///2|10-0-1,11-1-0
        /// </summary>
        public String SortIndex { get; set; }

        /// <summary>
        ///1550
        /// </summary>
        public object StandardPrice { get; set; }
    }

    public class SRI_AirlineBaseModelModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<AddFareListModel> AddFareList { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<AirTaxListModel> AirTaxList { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<CabinRateListModel> CabinRateList { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<CabinRuleRelationListModel> CabinRuleRelationList { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<CabinRuleRelationListForCKModel> CabinRuleRelationListForCK { get; set; }
        //public object CabinRuleRelationListForCK { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String CourtesyBusForCabinNO { get; set; }

        /// <summary>
        ///<CabinRuleCH><Item><CabinNO>Y</CabinNO> <SellCode>YCH--</SellCode><CabinRuleID>100223</CabinRuleID><CabinRuleDescription>退票收取10%手续费,免费改期,可升舱至Y舱与F舱,允许签转</CabinRuleDescription><NewPrice>780</NewPrice><RealPrice>780</RealPrice><SaleRuleParam>100223-0-0-YCH-0</SaleRuleParam></Item><Item><CabinNO>F</CabinNO> <SellCode>FCH--</SellCode><CabinRuleID>100223</CabinRuleID><CabinRuleDescription>退票收取10%手续费,免费改期,可升舱至Y舱与F舱,允许签转</CabinRuleDescription><NewPrice>1550</NewPrice><RealPrice>1550</RealPrice><SaleRuleParam>100223-0-0-FCH-0</SaleRuleParam></Item></CabinRuleCH><CabinRuleIN><Item><CabinNO>F</CabinNO> <SellCode>FIN--</SellCode><CabinRuleID>465</CabinRuleID><CabinRuleDescription>免费退票,免费改期,可升舱至Y舱与F舱,免费签转</CabinRuleDescription><NewPrice>310</NewPrice><RealPrice>310</RealPrice><SaleRuleParam></SaleRuleParam></Item><Item><CabinNO>Y</CabinNO> <SellCode>YIN--</SellCode><CabinRuleID>465</CabinRuleID><CabinRuleDescription>免费退票,免费改期,可升舱至Y舱与F舱,免费签转</CabinRuleDescription><NewPrice>160</NewPrice><RealPrice>160</RealPrice><SaleRuleParam></SaleRuleParam></Item></CabinRuleIN>
        /// </summary>
        public String DefaultCabinRuleForCH { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<DefaultSRI_CabinListForCHModel> DefaultSRI_CabinListForCH { get; set; }
        //public object DefaultSRI_CabinListForCH { get; set; }

        /// <summary>
        ///PVG
        /// </summary>
        public String DesCity { get; set; }

        /// <summary>
        ///True
        /// </summary>
        public Boolean IsCanCheckIn { get; set; }

        /// <summary>
        ///CKG
        /// </summary>
        public String OrgCity { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<SaleRuleListModel> SaleRuleList { get; set; }
        //public object SaleRuleList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String SaleRuleMultiList { get; set; }

        /// <summary>
        ///1550
        /// </summary>
        public object StandardPrice { get; set; }
    }

    public class AddFareListModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object AddFare { get; set; }

        /// <summary>
        ///136
        /// </summary>
        public String AddFareID { get; set; }

        /// <summary>
        ///2015136
        /// </summary>
        public String CodeName { get; set; }

        /// <summary>
        ///02/05/2015 01:32:30
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///12/31/2049 16:00:00
        /// </summary>
        public DateTime FlightEndDate { get; set; }

        /// <summary>
        ///02/04/2015 16:00:00
        /// </summary>
        public DateTime FlightStartDate { get; set; }

        /// <summary>
        ///10000
        /// </summary>
        public object MileEnd { get; set; }

        /// <summary>
        ///800
        /// </summary>
        public object MileStart { get; set; }

        /// <summary>
        ///12/31/2049 16:00:00
        /// </summary>
        public DateTime OrderEndDate { get; set; }

        /// <summary>
        ///02/04/2015 16:00:00
        /// </summary>
        public DateTime OrderStartDate { get; set; }

        /// <summary>
        ///20150205
        /// </summary>
        public String PolicyNo { get; set; }

        /// <summary>
        ///CH
        /// </summary>
        public String PsgType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object State { get; set; }
    }

    public class AirTaxListModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object AirTax { get; set; }

        /// <summary>
        ///8
        /// </summary>
        public object AirTaxID { get; set; }

        /// <summary>
        ///*
        /// </summary>
        public String CodeName { get; set; }

        /// <summary>
        ///11/29/2010 07:51:40
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///12/31/2049 16:00:00
        /// </summary>
        public DateTime FlightEndDate { get; set; }

        /// <summary>
        ///12/31/2009 16:00:00
        /// </summary>
        public DateTime FlightStartDate { get; set; }

        /// <summary>
        ///12/31/2049 16:00:00
        /// </summary>
        public DateTime OrderEndDate { get; set; }

        /// <summary>
        ///12/31/2009 16:00:00
        /// </summary>
        public DateTime OrderStartDate { get; set; }

        /// <summary>
        ///*
        /// </summary>
        public String PlaneModel { get; set; }

        /// <summary>
        ///未定机型
        /// </summary>
        public String PlaneNameCn { get; set; }

        /// <summary>
        ///unknown
        /// </summary>
        public String PlaneNameEn { get; set; }

        /// <summary>
        ///IN
        /// </summary>
        public String PsgType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object State { get; set; }
    }

    public class CabinRateListModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///*
        /// </summary>
        public String AirlineNO { get; set; }

        /// <summary>
        ///经济舱
        /// </summary>
        public String CabinMemo { get; set; }

        /// <summary>
        ///Y
        /// </summary>
        public String CabinNO { get; set; }

        /// <summary>
        ///17350
        /// </summary>
        public object CabinRateID { get; set; }

        /// <summary>
        ///20150825
        /// </summary>
        public String CodeName { get; set; }

        /// <summary>
        ///08/24/2015 07:17:44
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///12/30/2020 16:00:00
        /// </summary>
        public DateTime FlightEndDate { get; set; }

        /// <summary>
        ///08/23/2015 16:00:00
        /// </summary>
        public DateTime FlightStartDate { get; set; }

        /// <summary>
        ///12/30/2020 16:00:00
        /// </summary>
        public DateTime OrderEndDate { get; set; }

        /// <summary>
        ///08/23/2015 16:00:00
        /// </summary>
        public DateTime OrderStartDate { get; set; }

        /// <summary>
        ///100
        /// </summary>
        public object PriceRate { get; set; }

        /// <summary>
        ///AD
        /// </summary>
        public String PsgType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object State { get; set; }
    }

    public class CabinRuleRelationListModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public CabinRuleModel CabinRule { get; set; }
        //public object CabinRule { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public CabinRuleRelationModel CabinRuleRelation { get; set; }
        //public object CabinRuleRelation { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<ChannelModelListModel> ChannelModelList { get; set; }
        //public object ChannelModelList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String SaleRuleLog { get; set; }
    }

    public class CabinRuleModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///仅退机建费和燃油费，机票款不退,不得自愿改期或升舱,不允许签转
        /// </summary>
        public String CabinRuleDescription { get; set; }

        /// <summary>
        ///63970
        /// </summary>
        public object CabinRuleID { get; set; }

        /// <summary>
        ///客票类别为:[YZ]对舱位[Z]的客规配置的退改签
        /// </summary>
        public String CabinRuleName { get; set; }

        /// <summary>
        ///160
        /// </summary>
        public object CabinRuleRelationID { get; set; }

        /// <summary>
        ///94
        /// </summary>
        public String ChangeDateConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String ChangeDateConfigTxt { get; set; }

        /// <summary>
        ///08/05/2013 06:48:37
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsNoFirstAudit { get; set; }

        /// <summary>
        ///
        /// </summary>
        public Object ListChangeDateConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        public Object ListModifyPSGConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        public Object ListRefundConfig { get; set; }

        /// <summary>
        ///84
        /// </summary>
        public String ModifyPSGConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String ModifyPSGConfigTxt { get; set; }

        /// <summary>
        ///91
        /// </summary>
        public String RefundConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String RefundConfigTxt { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String RiseCabinConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String RiseCabinConfigTxt { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object SaleRuleID { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object State { get; set; }
    }

    public class CabinRuleRelationModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///仅退机建费和燃油费，机票款不退,不得自愿改期或升舱,不允许签转
        /// </summary>
        public String CabinDescription { get; set; }

        /// <summary>
        ///Z
        /// </summary>
        public String CabinNO { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object CabinRate { get; set; }

        /// <summary>
        ///160
        /// </summary>
        public object CabinRuleRelationID { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object CabinType { get; set; }

        /// <summary>
        ///08/05/2013 06:48:37
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///11/30/2020 16:00:00
        /// </summary>
        public DateTime FlightEndDate { get; set; }

        /// <summary>
        ///12/31/2010 16:00:00
        /// </summary>
        public DateTime FlightStartDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String InferSellCode { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsCanReInfer { get; set; }

        /// <summary>
        ///True
        /// </summary>
        public Boolean IsNeedInfer { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String ListProductChannel { get; set; }

        /// <summary>
        ///11/30/2020 16:00:00
        /// </summary>
        public DateTime OrderEndDate { get; set; }

        /// <summary>
        ///12/31/2010 16:00:00
        /// </summary>
        public DateTime OrderStartDate { get; set; }

        /// <summary>
        ///30
        /// </summary>
        public object PriceRateEnd { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object PriceRateStart { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String ProductCabinRule { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object RelationType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object SRI_ChannelFlag { get; set; }

        /// <summary>
        ///YZ
        /// </summary>
        public String SellCode { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object State { get; set; }

        /// <summary>
        ///8769
        /// </summary>
        public String Version { get; set; }
    }

    public class ChannelModelListModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///B2C2010
        /// </summary>
        public String ChannelCode { get; set; }

        /// <summary>
        ///1524
        /// </summary>
        public object ChannelID { get; set; }

        /// <summary>
        ///CabinRuleRelation
        /// </summary>
        public String ChannelRegCode { get; set; }

        /// <summary>
        ///08/05/2013 06:49:11
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///160
        /// </summary>
        public object OperationID { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String Remark { get; set; }
    }

    public class CabinRuleRelationListForCKModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }
        public CabinRuleModel CabinRule { get; set; }
        public CabinRuleRelationModel CabinRuleRelation { get; set; }
        public List<ChannelModelListModel> ChannelModelList { get; set; }
        /// <summary>
        ///
        /// </summary>
        public String SaleRuleLog { get; set; }
    }

    public class DefaultSRI_CabinListForCHModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String CabinFlag { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object CabinIndex { get; set; }

        /// <summary>
        ///F
        /// </summary>
        public String CabinNO { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String CabinName { get; set; }

        /// <summary>
        ///2
        /// </summary>
        public object CabinPsgType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String CabinRebate { get; set; }

        /// <summary>
        ///免费退票,免费改期,可升舱至Y舱与F舱,免费签转
        /// </summary>
        public String CabinRuleDescription { get; set; }

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
        public String CheckINAndMeal { get; set; }

        /// <summary>
        ///FIN
        /// </summary>
        public String FareBasis { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public HandingChargeModelModel HandingChargeModel { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object InputPsgMode { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsCheckIn { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsCourtesyBus { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsMileBank { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsMultiPackPrice { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsSA { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsSpecialOffer { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsT2 { get; set; }

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
        public String NewPriceText { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object OldAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String OldCabinNo { get; set; }

        /// <summary>
        ///310
        /// </summary>
        public object OldPrice { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean OnlySelf { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String OperateTypePrice { get; set; }

        /// <summary>
        ///908A42A6B710FA13597A10CFE8ABC464
        /// </summary>
        public String PassKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String PriceIconName { get; set; }

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
        public String RealPriceText { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String SaleInstruction { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object SaleRuleID { get; set; }

        /// <summary>
        ///465-0-0-FIN-0
        /// </summary>
        public String SaleRuleParam { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object Score { get; set; }

        /// <summary>
        ///FIN--
        /// </summary>
        public String SellCode { get; set; }

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
        public String UnMemberPriceText { get; set; }
    }

    public class HandingChargeModelModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object ChangeDateFare { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object ChangeDateFareOnly { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object DiffAddFare { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object DiffAirTax { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object DiffChangeDateCabin { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object FareUnit { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object HandlingCharge { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String HandlingChargeDesc { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object HandlingChargeFare { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object HandlingChargeRebateCH { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object HandlingChargeType { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object NowParPrice { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object RiseCabinFare { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object TicketID { get; set; }
    }

    public class SaleRuleListModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///CKG-PVG
        /// </summary>
        public String AirlineNO { get; set; }

        /// <summary>
        ///重庆-上海浦东
        /// </summary>
        public String AirlineName { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object AirlineType { get; set; }

        /// <summary>
        ///远期特价
        /// </summary>
        public String AirlineTypeText { get; set; }

        /// <summary>
        ///THMGSLQEVR
        /// </summary>
        public String CabinNO { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String CabinRuleModel { get; set; }

        /// <summary>
        ///03/26/2015 06:48:02
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///2015-03-26
        /// </summary>
        public DateTime CreateDateShortText { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object ExcelRowNO { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String FixedMile { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object FixedPrice { get; set; }

        /// <summary>
        ///12/30/2015 16:00:00
        /// </summary>
        public DateTime FlightEndDate { get; set; }

        /// <summary>
        ///2015-12-31
        /// </summary>
        public DateTime FlightEndDateShortText { get; set; }

        /// <summary>
        ///3U8***
        /// </summary>
        public String FlightNO { get; set; }

        /// <summary>
        ///10/10/2015 16:00:00
        /// </summary>
        public DateTime FlightStartDate { get; set; }

        /// <summary>
        ///2015-10-11
        /// </summary>
        public DateTime FlightStartDateShortText { get; set; }

        /// <summary>
        ///30
        /// </summary>
        public object FutureDay { get; set; }

        /// <summary>
        ///11191
        /// </summary>
        public object ImportFileID { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsCheckPrice { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean OnlySelf { get; set; }

        /// <summary>
        ///12/30/2015 16:00:00
        /// </summary>
        public DateTime OrderEndDate { get; set; }

        /// <summary>
        ///2015-12-31
        /// </summary>
        public DateTime OrderEndDateShortText { get; set; }

        /// <summary>
        ///03/22/2015 16:00:00
        /// </summary>
        public DateTime OrderStartDate { get; set; }

        /// <summary>
        ///2015-03-23
        /// </summary>
        public DateTime OrderStartDateShortText { get; set; }

        /// <summary>
        ///3U-EB-PFP 20150320
        /// </summary>
        public String PolicyNo { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String PriceConfig { get; set; }

        /// <summary>
        ///105
        /// </summary>
        public object ProductCategoryID { get; set; }

        /// <summary>
        ///提前30天订票
        /// </summary>
        public String ProductNameTextForFuture { get; set; }

        /// <summary>
        ///THMGSLQEVR=0.9
        /// </summary>
        public String RebatePrice { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String ReducePrice { get; set; }

        /// <summary>
        ///从EXCEL文件导入
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String SaleInstruction { get; set; }

        /// <summary>
        ///717455
        /// </summary>
        public String SaleRuleID { get; set; }

        /// <summary>
        ///SAYQ
        /// </summary>
        public String SellCode { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object ShowState { get; set; }

        /// <summary>
        ///1
        /// </summary>
        public object State { get; set; }

        /// <summary>
        ///启用
        /// </summary>
        public String StateText { get; set; }

        /// <summary>
        ///<font color='green'>启用</font>
        /// </summary>
        public String StateTextWithColor { get; set; }

        /// <summary>
        ///12/30/2015 16:00:00
        /// </summary>
        public DateTime ValidFlightEndDate { get; set; }

        /// <summary>
        ///12/02/2015 16:00:00
        /// </summary>
        public DateTime ValidFlightStartDate { get; set; }
    }

    public class SRI_FlightListModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String AArriveTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String ACReg { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String ATakeoffTime { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object AddFare { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object AddFareCH { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object AddFareIN { get; set; }

        /// <summary>
        ///50
        /// </summary>
        public object AirTax { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object AirTaxCH { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object AirTaxIN { get; set; }

        /// <summary>
        ///12/14/2015 01:45:00
        /// </summary>
        public DateTime ArriveTime { get; set; }

        /// <summary>
        ///09:45
        /// </summary>
        public String ArriveTimeShort { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public CabinModelModel CabinModel { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object ChangeDateFare { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String CloseDoorTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String DesCity { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String FlightCS { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String FlightDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String FlightDelay { get; set; }

        /// <summary>
        ///10
        /// </summary>
        public object FlightFlag { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object FlightIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String FlightIsNormal { get; set; }

        /// <summary>
        ///3U8971
        /// </summary>
        public String FlightNo { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String FlightType { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String FlightVR { get; set; }

        /// <summary>
        ///True
        /// </summary>
        public Boolean IsDirect { get; set; }

        /// <summary>
        ///True
        /// </summary>
        public Boolean IsReturn { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsShare { get; set; }

        /// <summary>
        ///460
        /// </summary>
        public object MiniPrice { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String OpenDoorTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String OrgCity { get; set; }

        /// <summary>
        ///320
        /// </summary>
        public object PlaneModel { get; set; }

        /// <summary>
        ///机型320(大)
        /// </summary>
        public String PlaneModelName { get; set; }

        /// <summary>
        ///http://125.69.90.49:6665/SCAL.WebMaster/FileUPload/GGImg/banner2.jpg
        /// </summary>
        public String PlaneModelURL { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object RiseCabinFare { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public List<SRI_CabinListModel> SRI_CabinList { get; set; }

        /// <summary>
        ///12/13/2015 23:25:00
        /// </summary>
        public DateTime TakeOffTime { get; set; }

        /// <summary>
        ///07:25
        /// </summary>
        public String TakeOffTimeShort { get; set; }

        /// <summary>
        ///02:20:00
        /// </summary>
        public String TotalFlightTime { get; set; }
    }

    public class CabinModelModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///1-10-104
        /// </summary>
        public String CabinFlag { get; set; }

        /// <summary>
        ///104
        /// </summary>
        public object CabinIndex { get; set; }

        /// <summary>
        ///N
        /// </summary>
        public String CabinNO { get; set; }

        /// <summary>
        ///折扣舱
        /// </summary>
        public String CabinName { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object CabinPsgType { get; set; }

        /// <summary>
        ///3.0折
        /// </summary>
        public String CabinRebate { get; set; }

        /// <summary>
        ///仅退机建费和燃油费，机票款不退,不得自愿改期或升舱,不允许签转
        /// </summary>
        public String CabinRuleDescription { get; set; }

        /// <summary>
        ///43451
        /// </summary>
        public object CabinRuleID { get; set; }

        /// <summary>
        ///60
        /// </summary>
        public object CategoryID { get; set; }

        /// <summary>
        ///提供网上值机,
        /// </summary>
        public String CheckINAndMeal { get; set; }

        /// <summary>
        ///N,N
        /// </summary>
        public String FareBasis { get; set; }

        /// <summary>
        ///class
        /// </summary>
        public HandingChargeModelModel HandingChargeModel { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object InputPsgMode { get; set; }

        /// <summary>
        ///True
        /// </summary>
        public Boolean IsCheckIn { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsCourtesyBus { get; set; }

        /// <summary>
        ///True
        /// </summary>
        public Boolean IsMileBank { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsMultiPackPrice { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsSA { get; set; }

        /// <summary>
        ///True
        /// </summary>
        public Boolean IsSpecialOffer { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsT2 { get; set; }

        /// <summary>
        ///{}
        /// </summary>
        public object MultiMorePrice { get; set; }

        /// <summary>
        ///10
        /// </summary>
        public object NewAmount { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object NewMile { get; set; }

        /// <summary>
        ///460
        /// </summary>
        public object NewPrice { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String NewPriceText { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object OldAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String OldCabinNo { get; set; }

        /// <summary>
        ///470
        /// </summary>
        public object OldPrice { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean OnlySelf { get; set; }

        /// <summary>
        ///打9.70折
        /// </summary>
        public String OperateTypePrice { get; set; }

        /// <summary>
        ///87DEC7CC5B6378790656EA0EC9682173
        /// </summary>
        public String PassKey { get; set; }

        /// <summary>
        ///1
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
        ///460
        /// </summary>
        public object RealPrice { get; set; }

        /// <summary>
        ///￥460
        /// </summary>
        public String RealPriceText { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String SaleInstruction { get; set; }

        /// <summary>
        ///909916
        /// </summary>
        public String SaleRuleID { get; set; }

        /// <summary>
        ///43451-909916-60-N,N-0
        /// </summary>
        public String SaleRuleParam { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object Score { get; set; }

        /// <summary>
        ///SAZH--
        /// </summary>
        public String SellCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object TicketID { get; set; }

        /// <summary>
        ///-1
        /// </summary>
        public object UnMemberPrice { get; set; }

        /// <summary>
        ///￥-1
        /// </summary>
        public String UnMemberPriceText { get; set; }
    }

    public class SRI_CabinListModel
    {

        /// <summary>
        ///{}
        /// </summary>
        public object ExtensionData { get; set; }

        /// <summary>
        ///1-10-103
        /// </summary>
        public String CabinFlag { get; set; }

        /// <summary>
        ///103
        /// </summary>
        public object CabinIndex { get; set; }

        /// <summary>
        ///Y
        /// </summary>
        public String CabinNO { get; set; }

        /// <summary>
        ///经济舱
        /// </summary>
        public String CabinName { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object CabinPsgType { get; set; }

        /// <summary>
        ///8.8折
        /// </summary>
        public String CabinRebate { get; set; }

        /// <summary>
        ///退票收取10%手续费,免费改期,仅允许同价签转
        /// </summary>
        public String CabinRuleDescription { get; set; }

        /// <summary>
        ///97692
        /// </summary>
        public String CabinRuleID { get; set; }

        /// <summary>
        ///60
        /// </summary>
        public object CategoryID { get; set; }

        /// <summary>
        ///提供网上值机,
        /// </summary>
        public String CheckINAndMeal { get; set; }

        /// <summary>
        ///Y,YY
        /// </summary>
        public String FareBasis { get; set; }

        public HandingChargeModelModel HandingChargeModel { get; set; } 
        /// <summary>
        ///0
        /// </summary>
        public object InputPsgMode { get; set; }

        /// <summary>
        ///True
        /// </summary>
        public Boolean IsCheckIn { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsCourtesyBus { get; set; }

        /// <summary>
        ///True
        /// </summary>
        public Boolean IsMileBank { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsMultiPackPrice { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsSA { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsSpecialOffer { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean IsT2 { get; set; }

        /// <summary>
        ///{}
        /// </summary>
        public object MultiMorePrice { get; set; }

        /// <summary>
        ///10
        /// </summary>
        public object NewAmount { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object NewMile { get; set; }

        /// <summary>
        ///1360
        /// </summary>
        public object NewPrice { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String NewPriceText { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object OldAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String OldCabinNo { get; set; }

        /// <summary>
        ///1550
        /// </summary>
        public object OldPrice { get; set; }

        /// <summary>
        ///False
        /// </summary>
        public Boolean OnlySelf { get; set; }

        /// <summary>
        ///打8.80折
        /// </summary>
        public String OperateTypePrice { get; set; }

        /// <summary>
        ///577FC4CAF7BE2D143F927927884DB01D
        /// </summary>
        public String PassKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String PriceIconName { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object PriceUnit { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object PromotionCardFavorID { get; set; }

        /// <summary>
        ///1360
        /// </summary>
        public object RealPrice { get; set; }

        /// <summary>
        ///￥1360
        /// </summary>
        public String RealPriceText { get; set; }

        /// <summary>
        ///
        /// </summary>
        public String SaleInstruction { get; set; }

        /// <summary>
        ///914871
        /// </summary>
        public String SaleRuleID { get; set; }

        /// <summary>
        ///97692-914871-60-Y,YY-0
        /// </summary>
        public String SaleRuleParam { get; set; }

        /// <summary>
        ///0
        /// </summary>
        public object Score { get; set; }

        /// <summary>
        ///SAZH--
        /// </summary>
        public String SellCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        public object TicketID { get; set; }

        /// <summary>
        ///-1
        /// </summary>
        public object UnMemberPrice { get; set; }

        /// <summary>
        ///￥-1
        /// </summary>
        public String UnMemberPriceText { get; set; }
    }

}