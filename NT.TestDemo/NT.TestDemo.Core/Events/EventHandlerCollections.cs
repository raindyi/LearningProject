//**********************************************
//Events collections 事件集合
//Creater Lynn
//CreatedTime 2015.10.19 11:06
//**********************************************
using System;
using NT.TestDemo.Common.Model;

namespace NT.TestDemo.Core.Events
{
    public class RecordMessageEventArgs
    {
        public String Message { get; set; }
        public Guid Id { get; set; }

        public Exception Exception { get; set; }
    }

    public delegate void RecordMessageEventHandler(RecordMessageEventArgs messageEventArgs);

    public delegate void LoginProcessEventHandler(HandlingResult loginEventArgs);
}