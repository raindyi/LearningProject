using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Appender;
using log4net.Config;
using NT.TestDemo.Common.Helper;
using NT.TestDemo.Log.Model;
using NT.TestDemo.PL.Model;
using NT.TestDemo.UI.Forms;

namespace NT.TestDemo.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BasicConfigurator.Configure();
            ConfigLogConnection();
            
            Application.Run(new FormCapture());
        }

        private static void ConfigLogConnection()
        {
            if (String.IsNullOrEmpty(ConfigInformation.Connectiong))
            {
                string connstr = ConfigurationManager.AppSettings.Get("Connection");
                var helper = new DecryptAndEncryptionHelper(ConfigInformation.Key, ConfigInformation.Vector);
                connstr = helper.Decrypto(connstr);

                ConfigInformation.Connectiong = connstr;
            }
            IAppender[] appenders = log4net.LogManager.GetRepository().GetAppenders();
            foreach (IAppender appender in appenders)
            {
                if (appender.GetType() == typeof(AdoNetAppender))
                {
                    ((AdoNetAppender)appender).ConnectionString = ConfigInformation.Connectiong;
                    ((AdoNetAppender)appender).ActivateOptions();
                }
            }
        }
    }
}
