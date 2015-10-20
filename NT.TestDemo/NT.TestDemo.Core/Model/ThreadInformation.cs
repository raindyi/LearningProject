using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NT.TestDemo.Core.Model
{
    public class ThreadInformation
    {
        public Int32 Id { get; set; }
        public Thread ProcessThread { get; set; }
        public Boolean Flag { get; set; }
        public long ExecutionTimes { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime LastedStopTime { get; set; }
    }
}
