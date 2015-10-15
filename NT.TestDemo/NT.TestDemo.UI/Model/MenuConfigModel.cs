using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT.TestDemo.UI.Model
{
    public class MenuConfigModel
    {
        public String Config { get; set; }
        public String Text { get; set; }

        public String TipText { get; set; }

        public Boolean IsSeparate { get; set; }

        public MenuConfigModel()
        {
            IsSeparate = false;
        }
    }
}
