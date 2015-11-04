//**********************************************
//自定义配置Model
//Creater Lynn
//CreatedTime 2015.10.18 11:42
//**********************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NT.TestDemo.UI.Lib;

namespace NT.TestDemo.UI.Model
{
    /// <summary>
    /// 自定义配置Model
    /// </summary>
    public class CustomerConfigModel
    {
        #region Veriable
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String AC { get; set; }
        public String PW { get; set; }
        public String LU { get; set; }
        private Boolean _vca;
        /// <summary>
        /// 是否需要输入验证码
        /// </summary>
        public Boolean VCA
        {
            get { return _vca; }
        }

        public String VCAS {
            set { Boolean.TryParse(value, out _vca); }
        }
        public String VCU { get; set; }

        public object ManualHandler { get; set; }
        #endregion
        public String LSTU { get; set; }

        public String LSC { get; set; }

        private Boolean _cc;
        public Boolean CC {
            get { return _cc; }
        }
        public String CCS {
            set { Boolean.TryParse(value, out _cc); }
        }

        #region Structure
        public CustomerConfigModel()
        {
        }
        #endregion

        #region Function
        #endregion
    }
}
