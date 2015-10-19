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
        public Boolean VCA
        {
            get { return _vca; }
        }

        public String VCAS {
            set { Boolean.TryParse(value, out _vca); }
        }
        public String VCU { get; set; }
        #endregion

        #region Structure
        public CustomerConfigModel()
        {
        }
        #endregion

        #region Function
        #endregion
    }
}
