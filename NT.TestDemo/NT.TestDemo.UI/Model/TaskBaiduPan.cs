//**********************************************
//TaskBaiduPan 任务类
//Creater Lynn
//CreatedTime 2015.10.19 11:06
//**********************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using NT.TestDemo.Core.Model;

namespace NT.TestDemo.UI.Model
{
    /// <summary>
    /// 任务类
    /// </summary>
    public class TaskBaiduPan :TaskProcessor
    {
        #region Veriable

        private ILog _log = LogManager.GetLogger(typeof(TaskBaiduPan));
        #endregion

        #region Structure
        #endregion

        #region ITask Interface
        public override void Work()
        {
            StartTask();
            _log.Debug(String.Format("TaskBaiduPan[{0}] now is working", TaskId));

            EndTask();
        }
        protected override void Error()
        {
            throw new NotImplementedException();
        }
        #endregion


        
    }
}
