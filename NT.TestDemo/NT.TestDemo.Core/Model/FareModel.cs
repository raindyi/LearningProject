using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT.TestDemo.Core.Model
{
    public class FareModel
    {
        public String FareCode { get; set; }
        public String ExportId { get; set; }
        public DateTime StartSDate { get; set; }
        public DateTime? StartFDate { get; set; }
        public DateTime FinishSDate { get; set; }
        public DateTime? FinishFDate { get; set; }
        public String FlightNo { get; set; }
        public Int32 TicketPrice { get; set; }
        public String AW { get; set; }
        public String DepCode { get; set; }
        public String ArrCode { get; set; }
        public String Cabin { get; set; }
    }
}
