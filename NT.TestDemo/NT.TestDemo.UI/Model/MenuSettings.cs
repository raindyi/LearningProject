using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT.TestDemo.UI.Model
{
    public static class MenuSettings
    {
        public static Dictionary<String, MenuConfigModel> NotifyMenu =
            new Dictionary<string, MenuConfigModel>()
            {
                {
                    "START", new MenuConfigModel()
                    {
                        Config = "START",
                        Text = "启动服务",
                        TipText = "启动任务服务。如果服务已经启动，再次启动可能引起异常"
                    }
                },
                {
                    "END", new MenuConfigModel()
                    {
                        Config = "END",
                        Text = "停止服务",
                        TipText = "停止任务服务。服务停止前需要完成所有正在运行中的任务,请耐心等待"
                    }
                },
                {
                    "SEPA1", new MenuConfigModel()
                    {
                        IsSeparate = true
                    }
                },
                {
                    "CONFIG", new MenuConfigModel()
                    {
                        Config = "CONFIG",
                        Text = "任务设置",
                        TipText = "配置任务服务执行的基础信息"
                    }
                },
                {
                    "SEPA2", new MenuConfigModel()
                    {
                        IsSeparate = true
                    }
                },
                {
                    "EXIT", new MenuConfigModel()
                    {
                        Config = "EXIT",
                        Text = "退出服务系统",
                        TipText = "停止服务,并退出系统"
                    }
                },
            };

    }
}
