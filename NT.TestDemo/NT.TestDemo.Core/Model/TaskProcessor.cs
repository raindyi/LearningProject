//**********************************************
//TaskProcessor 任务处理基类
//Creater Lynn
//CreatedTime 2015.10.19 09:00
//**********************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace NT.TestDemo.Core.Model
{
    /// <summary>
    /// 任务处理基类
    /// </summary>
    public abstract class TaskProcessor
    {
        #region Veriable
        public Boolean Flag = true;
        public Guid TaskId;
        protected DateTime StartTime = DateTime.MinValue;
        protected DateTime EndTime = DateTime.MinValue;
        public Int32 PauseCount { get; set; }
        private ILog _log = LogManager.GetLogger(typeof(TaskProcessor));
        protected TaskStateEnum _state;
        public TaskStateEnum State
        {
            get { return _state; }
        }
        public String Message { get; set; }
        private Int32 _executionCounts = 0;
        #endregion

        #region Structure
        public TaskProcessor()
        {
            TaskId = Guid.NewGuid();
        }
        #endregion

        #region Function

        protected void StartTask()
        {
            StartTime = DateTime.Now;
            _log.Debug(String.Format("{0}:StartTask",TaskId));
        }

        protected void EndTask()
        {
            EndTime = DateTime.Now;
            _log.Debug(String.Format("{0}:EndTask", TaskId));
        }

        protected void PauseStartTask()
        {

        }
        protected void PauseEndTask()
        {
            PauseCount++;
        }
        #endregion

        public abstract void Work();
        protected abstract void Error();
    }
}
