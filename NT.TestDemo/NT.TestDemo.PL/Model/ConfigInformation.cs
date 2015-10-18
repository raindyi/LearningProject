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

        public static String Key = "187ce9d9-837e-41f4-9060-6856b8c03964";
        public static String Vector = "fd5e4a0a-2215-4b34-a554-5875685239b0";
        public static String Connectiong = "";
        public ConfigInformation() { }
    }
}
