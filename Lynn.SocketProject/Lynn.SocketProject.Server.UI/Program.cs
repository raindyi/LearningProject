using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using log4net.Config;

namespace Lynn.SocketProject.Server.UI
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
            Application.Run(new ServerForm());
        }
    }
}
