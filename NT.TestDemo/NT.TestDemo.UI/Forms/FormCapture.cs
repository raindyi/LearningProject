using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using NT.TestDemo.Core.Lib;
using NT.TestDemo.Core.Model;
using NT.TestDemo.UI.Lib;
using NT.TestDemo.UI.Model;

namespace NT.TestDemo.UI.Forms
{
    public partial class FormCapture : BaseForm
    {
        #region Veriable

        private ILog _log = LogManager.GetLogger(typeof(FormCapture));
        #endregion
        #region Structure
        public FormCapture()
        {
            InitializeComponent();
        }
        #endregion

        #region Function

        private void InitLoad()
        {
            InitControls();
            InitControlsData();
        }

        private void InitControls()
        {
            btnExit.Location=new Point(splitContainerMain.Size.Width-30,btnExit.Location.Y);
        }

        private void InitControlsData()
        {
            Dictionary<Guid,CustomerConfigModel> models= ConfigLib.Instance("").LoadConfig();
            foreach (var model in models.Values)
            {
                comboBoxConfig.Items.Add(model);
            }
            try
            {
                comboBoxConfig.DisplayMember = "Name";
                //comboBoxConfig.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
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

        private void comboBoxConfig_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomerConfigModel model = comboBoxConfig.SelectedItem as CustomerConfigModel;
            textBoxUser.Text = model.AC;
            textBoxPassword.Text = model.PW;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Dictionary<Guid, TaskProcessor> tasks=new Dictionary<Guid, TaskProcessor>();
            for (Int32 i = 0; i < 20; i++)
            {
                Guid id = Guid.NewGuid();
                tasks.Add(id,new TaskBaiduPan()
                {
                    TaskId =id
                });
            }
            MultithreadingServices.Instance().Assignment(tasks).Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MultithreadingServices.Instance().End();
        }

    }
}
