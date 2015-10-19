using System;

namespace NT.TestDemo.Core.Model
{
    public enum ServiceStateEnum
    {
        Initialize = 1,
        Runing = 2,
        Pause = 4,
        Error = 8,
        End = 16
    }

    [Flags]
    public enum TaskStateEnum
    {
        Created=1,
        Initialize=2,
        Runing=4,
        Pause=8,
        Error=16,
        End=32
    }
}