using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT.MultithreadingTaskService.UI.Forms
{
    public partial class FormCapture : BaseForm
    {
        public FormCapture()
        {
            InitializeComponent();
        }

        #region Function

        private void InitLoad()
        {
            InitControls();
        }

        private void InitControls()
        {
            btnExit.Location=new Point(splitContainerMain.Size.Width-30,btnExit.Location.Y);
        }

        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Controls Event
        private void FormCapture_Load(object sender, EventArgs e)
        {
            InitLoad();
        }
        #endregion

    }
}
