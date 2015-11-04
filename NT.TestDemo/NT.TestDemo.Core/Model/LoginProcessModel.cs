using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace NT.TestDemo.Core.Model
{
    public class LoginProcessModel
    {
        private Uri _loginUrl;

        public Uri LoginUrl
        {
            get { return _loginUrl; }
            set { _loginUrl = value; }
        }

        private Boolean _containsCook = true;
        public Boolean ContainsCook {
            get { return _containsCook; }
            set { _containsCook = value; }
        }

        private Uri _loginSuccessedTransforUrl;
        public Uri LoginSuccessedTransforUrl
        {
            get { return _loginSuccessedTransforUrl; }
            set { _loginSuccessedTransforUrl = value; }
        }

        private String _loginCondition = "";
        public String LoginCondition {
            get { return _loginCondition; }
            set { _loginCondition = value; }
        }
    }
}
