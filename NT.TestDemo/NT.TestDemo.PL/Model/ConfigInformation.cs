using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NT.TestDemo.PL.Model
{
    public class ConfigInformation
    {
        private static ConfigInformation _configInformation;
        public ConfigInformation Instance {
            get
            {
                if (_configInformation == null)
                {
                    _configInformation = new ConfigInformation();
                }
                return _configInformation;
            }
        }

        public static String Key = "8040349e-a1f2-4d0a-b158-6e8b74dfade7";
        public static String Vector = "2875aab1-79c4-4a7e-94f7-14545c501be7";
        public static String Connectiong = "";
        public ConfigInformation() { }
    }
}
