//**********************************************
//基本配置表示层处理逻辑
//Creater Lynn
//CreatedTime 2015.10.15 14:31
//**********************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT.MultithreadingTaskService.UI.Lib
{
    /// <summary>
    /// 基本配置表示层处理逻辑
    /// </summary>
    public class ConfigLib
    {
        #region Veriable

        private readonly String DefaultDirectory = String.Format("{0}/{1}",Application.StartupPath,"Config");
        private readonly String DefaultName = "TaskInformation";

        private String _filepath;
        #endregion

        #region Structure
        public ConfigLib()
        {
            _filepath = String.Format("{0}/{1}", DefaultDirectory, DefaultName);
        }
        public ConfigLib(String filepath)
        {
            _filepath = filepath;
        }
        #endregion

        #region Function

        #endregion
    }
}
