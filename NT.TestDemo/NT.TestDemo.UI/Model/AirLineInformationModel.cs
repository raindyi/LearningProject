using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT.TestDemo.UI.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AirLineInformationModel
    {
        public String Message { get; set; }
        public Boolean IsDirect { get; set; }
        public Boolean Result { get; set; }
        public AirlineDetailModel AirlineDetail { get; set; }
        public String AirlineListJSON { get; set; }
        public AirLineInformationModel()
        {
            
        }

    }

    #region AirlineDetailModel
    public class AirlineDetailModel
    {
        public object ExtensionData { get; set; }
        public String AirlineFlag { get; set; }
        public String DefaultCabinRuleForCH { get; set; }
        public String DesCity { get; set; }
        public String DesCityName { get; set; }
        public String Error { get; set; }
        public Int32 FareUnit { get; set; }
        public String FareUnitSymbol { get; set; }
        public DateTime FlightDate { get; set; }
        public String FlightDateText { get; set; }
        public String InputPsgMode { get; set; }
        public String LowestDiscount { get; set; }
        public Int32 OrderType { get; set; }
        public String OrgCity { get; set; }
        public String OrgCityName { get; set; }
        public String PsgType { get; set; }
        public String RouteName { get; set; }
        public SRI_AirlineInformationModel SRI_AirlineBaseModel { get; set; }
        public object SRI_FlightList { get; set; }
        public String SortIndex { get; set; }
        public Int32 StandardPrice { get; set; }
    }
    #region SRI_AirlineInformationModel
    public class SRI_AirlineInformationModel
    {
        public object ExtensionData { get; set; }
        public List<AddFareModel> AddFareList { get; set; }
        public List<AirTaxModel> AirTaxList { get; set; }
        public List<CabinRateModel> CabinRateList { get; set; }
        public object CabinRuleRelationList { get; set; }
        public object CabinRuleRelationListForCK { get; set; }
        public String CourtesyBusForCabinNO { get; set; }
        public String DefaultCabinRuleForCH { get; set; }
        public object DefaultSRI_CabinListForCH { get; set; }
        public String DesCity { get; set; }
        public Boolean IsCanCheckIn { get; set; }
        public String OrgCity { get; set; }
        public object SaleRuleList { get; set; }
        public String SaleRuleMultiList { get; set; }
        public Int32 StandardPrice { get; set; }
    }

    public class AddFareModel
    {
        public object ExtensionData { get; set; }
        public Int32 AddFare { get; set; }
        public Int32 AddFareID { get; set; }
        public String CodeName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime FlightEndDate { get; set; }
        public DateTime FlightStartDate { get; set; }
        public Int32 MileEnd { get; set; }
        public Int32 MileStart { get; set; }
        public DateTime OrderEndDate { get; set; }
        public DateTime OrderStartDate { get; set; }
        public String PolicyNo { get; set; }
        public String PsgType { get; set; }
        public String Remark { get; set; }
        public Int32 State { get; set; }
    }

    public class AirTaxModel
    {
        public object ExtensionData { get; set; }
        public Int32 AirTax { get; set; }
        public Int32 AirTaxID { get; set; }
        public String CodeName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime FlightEndDate { get; set; }
        public DateTime FlightStartDate { get; set; }
        public DateTime OrderEndDate { get; set; }
        public DateTime OrderStartDate { get; set; }
        public String PlaneModel { get; set; }
        public String PlaneNameCn { get; set; }
        public String PlaneNameEn { get; set; }
        public String PsgType { get; set; }
        public String Remark { get; set; }
        public Int32 State { get; set; }
    }

    public class CabinRateModel 
    {
        public object ExtensionData { get; set; }
        public String AirlineNO { get; set; }
        public String CabinMemo { get; set; }
        public String CabinNO { get; set; }
        public Int32 CabinRateID { get; set; }
        public String CodeName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime FlightEndDate { get; set; }
        public DateTime OrderEndDate { get; set; }
        public DateTime OrderStartDate { get; set; }
        public Int32 PriceRate { get; set; }
        public String PsgType { get; set; }
        public String Remark { get; set; }
        public Int32 State { get; set; }
    }

    //public class CabinRuleRelationModel
    //{
    //    public object ExtensionData { get; set; }
    //    public object CabinRule { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //}

    //public class CabinRuleModel
    //{
    //    public object ExtensionData { get; set; }
    //    public object CabinRuleDescription { get; set; }
    //    public object CabinRuleID { get; set; }
    //    public object CabinRuleName { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //    public object ExtensionData { get; set; }
    //}

    #endregion
    #endregion
    public class BaseInformationModel
    {
        public object ExtensionData { get; set; }
        public String PsgType { get; set; }
        public String Remark { get; set; }
        public Int32 State { get; set; }
    }
}
