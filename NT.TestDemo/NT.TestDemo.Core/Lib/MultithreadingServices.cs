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
        private Int32 _taskAmount = 1;
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
        private Dictionary<Int32, ThreadInformation> _threadPools = new Dictionary<Int32, ThreadInformation>();
        //private ThreadStart _threadStart = null;
        private Boolean _serviceFlag = true;
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
            _serviceFlag = false;
            foreach (var thread in _threadPools)
            {
                thread.Value.Flag = false;
                thread.Value.ProcessThread.Abort();
                thread.Value.LastedStopTime = DateTime.Now;
            }
        }

        public void Pause()
        {
            _serviceFlag = !_serviceFlag;
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

        public List<ThreadSimpleInformation> Summary()
        {
            List<ThreadSimpleInformation> list=new List<ThreadSimpleInformation>();
            foreach (ThreadInformation information in _threadPools.Values)
            {
                list.Add(new ThreadSimpleInformation()
                {
                    Id = information.Id,
                    ExecutionTimes = information.ExecutionTimes,
                    Flag = information.Flag,
                    StartTime = information.StartTime,
                    LastedStopTime = information.LastedStopTime
                });
            }
            return list;
        }

        private void ServiceStart()
        {
            _serviceFlag = true;
            _state = ServiceStateEnum.Runing;
            //_threadStart = new ThreadStart(RunService);
            InitThreadPool();
            _log.Debug("MultithreadingServices Start");
            foreach (ThreadInformation t in _threadPools.Values)
            {
                t.Flag = true;
                if (t.StartTime.Equals(DateTime.MinValue))
                {
                    t.StartTime = DateTime.Now;
                }
                if (t.ProcessThread.ThreadState == ThreadState.Stopped ||
                    t.ProcessThread.ThreadState == ThreadState.Unstarted||
                    t.ProcessThread.ThreadState==ThreadState.Aborted)
                {
                    t.ProcessThread.Start();
                    
                }
            }
        }

        private void InitThreadPool()
        {
            _threadPools.Clear();
            for (Int32 i = 0; i < _taskAmount; i++)
            {
                ThreadInformation _information = new ThreadInformation()
                {
                    Flag = false,
                    LastedStopTime = DateTime.MinValue,
                    StartTime = DateTime.MinValue,
                    ProcessThread = new Thread(RunService),
                    ExecutionTimes = 0
                };
                _information.Id = _information.ProcessThread.ManagedThreadId;
                _threadPools.Add(_information.Id,_information);
            }
        }

        private void RunService()
        {
            while (_serviceFlag)
            {
                if (_queue.Count > 0)
                {
                    TaskProcessor processor = null;
                    lock (_lockobjThread)
                    {
                        processor = _queue.Dequeue();
                    }
                    _log.Info(String.Format("Task[{0}]State[{1}] is working by thread [{2}]:", processor.TaskId, processor.State,Thread.CurrentThread.ManagedThreadId));
                    if (RecordMessageEvent != null)
                    {
                        RecordMessageEvent(new RecordMessageEventArgs()
                        {
                            Id = processor.TaskId,
                            Message = String.Format("Task[{0}]State[{1}] is working by thread [{2}]:", processor.TaskId, processor.State, Thread.CurrentThread.ManagedThreadId)
                        });
                    }
                    processor.Work();
                    if (RecordMessageEvent != null)
                    {
                        RecordMessageEvent(new RecordMessageEventArgs()
                        {
                            Id = processor.TaskId,
                            Message = String.Format("Task[{0}]State[{1}] worked result\r\n [{2}]:", processor.TaskId, processor.State, processor.Message)
                        });
                    }
                    _threadPools[Thread.CurrentThread.ManagedThreadId].ExecutionTimes++;
                    _threadPools[Thread.CurrentThread.ManagedThreadId].Flag = true;
                    Thread.Sleep(1000);
                }
                else
                {
                    if (RecordMessageEvent != null)
                    {
                        RecordMessageEvent(new RecordMessageEventArgs()
                        {
                            Id = Guid.Empty,
                            Message = "Task queue is empty"
                        });
                    }
                    _log.Error("Task queue is empty");
                    Thread.Sleep(DefSleepInterval);
                }
            }
        }

        #endregion
    }
}
