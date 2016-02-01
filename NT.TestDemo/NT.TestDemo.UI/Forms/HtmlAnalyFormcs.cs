using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NT.TestDemo.Core.Lib;

namespace NT.TestDemo.UI.Forms
{
    public partial class HtmlAnalyFormcs : Form
    {
        public HtmlAnalyFormcs()
        {
            InitializeComponent();
        }

        private void Analy()
        {
            String path = String.Format("{0}HTML\\TestPage.html", AppDomain.CurrentDomain.BaseDirectory);
            HtmlAnalyLib lib=new HtmlAnalyLib();
            lib.AnalyHtml(path);
        }

        private void HtmlAnalyFormcs_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Analy();
        }
    }
}
