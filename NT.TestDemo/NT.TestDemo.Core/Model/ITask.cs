//**********************************************
//ITask 任务接口
//Creater Lynn
//CreatedTime 2015.10.19 08:59
//**********************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT.TestDemo.Core.Model
{
    /// <summary>
    /// 任务接口
    /// </summary>
    public interface ITask
    {
        void Start();
        void End();
        void Pause();
        void Continue();
        void Error();
        Int32 GetExecutionCounts();
        void AddExecutionCount();
    }
}
