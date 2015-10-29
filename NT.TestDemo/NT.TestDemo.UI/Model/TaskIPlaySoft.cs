using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using NT.TestDemo.Common.WebClientHelper;
using NT.TestDemo.Core.Model;
using NT.TestDemo.Log.Model;

namespace NT.TestDemo.UI.Model
{
    public class TaskIPlaySoft : TaskProcessor
    {
        #region Veriable

        private ILog _log = LogManager.GetLogger(typeof(TaskBaiduPan));
        private ILog _logdb = LogManager.GetLogger("TaskResultLogger");
        private String _pageUrl="{0}/page/{1}";
        public CustomerConfigModel Model { get; set; }
        public Int32 PageNum { get; set; }
        
        #endregion

        #region Structure
        public TaskIPlaySoft()
        {
        }

        #endregion

        #region ITask Interface
        public override void Work()
        {
            StartTask();
            String url = String.Format(_pageUrl, Model.LU, PageNum);
            XWebClient _client = new XWebClient();
            _client.Encoding = System.Text.Encoding.UTF8;
            String svreturn = _client.DownloadString(url);
            TaskResultLogModel model = new TaskResultLogModel()
            {
                Creator = "Tester",
                ResultInfo = svreturn,
                Updator = "Tester",
                Url = url
            };
            _logdb.Info(model);
            EndTask();
        }

        protected override void Error()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
