using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using NT.TestDemo.Core.Model;
using NT.TestDemo.UI.Lib;

namespace NT.TestDemo.UI.Model
{
    public class TaskSchAir :TaskProcessor
    {
        #region Veriable

        private ILog _log = LogManager.GetLogger(typeof(TaskSchAir));
        public SchAirlineWBMHandler ManualHandler { get; set; }
        public CustomerConfigModel ConfigModel { get; set; }
        #endregion
        public SchAirlineQueryJsonModel SingleModel { get; set; }
        #region Structure

        public TaskSchAir()
        {
        }

        #endregion

        #region implement TaskProcessor 
        public override void Work()
        {
            if (ManualHandler != null)
            {
                List<String> result= ManualHandler.QuerySingle(new Uri("http://www.scal.com.cn/Web/ETicket/GetSingleChina"), SingleModel);
                if (result != null && result.Count > 0)
                {
                    foreach (var msg in result)
                    {
                        String str = msg.Replace("{", "[").Replace("}", "]").Replace("\"", "'");
                        Message += String.Format("{0}\r\n{1}", Message, str);
                    }
                }
                Thread.Sleep(2000);
            }
        }

        protected override void Error()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Function
        #endregion
    }
}
