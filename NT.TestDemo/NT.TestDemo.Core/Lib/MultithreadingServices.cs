//**********************************************
//MultithreadingServices 多线程服务类
//Creater Lynn
//CreatedTime 2015.10.19 08:34
//**********************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using NT.TestDemo.Core.Events;
using NT.TestDemo.Core.Model;

namespace NT.TestDemo.Core.Lib
{
    /// <summary>
    /// 多线程服务类
    /// </summary>
    public class MultithreadingServices
    {
        #region Veriable
        private static object _lockobj=new object();
        private static object _lockobjThread=new object();
        private static MultithreadingServices _services;
        private Int32 _taskAmount = 10;
        public Int32 TaskAmount {
            get { return _taskAmount; }
            set { _taskAmount = value; }
        }
        public Dictionary<Guid, TaskProcessor> Tasks = new Dictionary<Guid, TaskProcessor>();
        private ServiceStateEnum _state;
        public ServiceStateEnum State
        {
            get { return _state; }
        }

        public event RecordMessageEventHandler RecordMessageEvent;
        private Queue<TaskProcessor> _queue = new Queue<TaskProcessor>();
        private ILog _log = LogManager.GetLogger(typeof(MultithreadingServices));
        private const Int32 DefSleepInterval = 2000;
        private List<Thread> _threadPools=new List<Thread>(); 
        #endregion

        #region Structure

        public MultithreadingServices()
        {
            _state = ServiceStateEnum.Initialize;
        }
        #endregion

        #region
        public static MultithreadingServices Instance()
        {
            lock (_lockobj)
            {
                if (_services == null)
                {
                    _services = new MultithreadingServices();
                }
            }
            return _services;
        }

        public void Start()
        {
            ServiceStart();
        }

        public void Start(Int32 amount)
        {
            _taskAmount = amount;
            ServiceStart();
        }

        public void End()
        {
            foreach (var thread in _threadPools)
            {
                thread.Abort();
            }
        }

        public MultithreadingServices Assignment(Dictionary<Guid, TaskProcessor> assignmentTasks)
        {
            foreach (var task in assignmentTasks)
            {
                if (!Tasks.ContainsKey(task.Key))
                {
                    Tasks.Add(task.Key, task.Value);
                }
                _queue.Enqueue(task.Value);
            }
            return _services;
        }

        private void ServiceStart()
        {
            _state = ServiceStateEnum.Runing;
            ThreadStart start=new ThreadStart(RunService);
        }

        private void RunService()
        {
            if (_queue.Count > 0)
            {
                TaskProcessor processor = null;
                lock (_lockobjThread)
                {
                    processor = _queue.Dequeue();
                }
                _log.Info(String.Format("Task[{0}] is working:[{1}]", processor.TaskId, processor.State));
                RecordMessageEvent(new RecordMessageEventArgs()
                {
                    Id = processor.TaskId,
                    Message = String.Format("Task[{0}] is working:[{1}]", processor.TaskId, processor.State)
                });
                processor.Work();
            }
            else
            {
                _log.Error("Task queue is empty");
                Thread.Sleep(DefSleepInterval);
            }
        }

        #endregion
    }
}
