using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using NT.TestDemo.Core.Lib;
using NT.TestDemo.Core.Model;
using NT.TestDemo.Log.Model;
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
            btnPause.Enabled = false;
            btnStop.Enabled = false;
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

        void services_RecordMessageEvent(Core.Events.RecordMessageEventArgs messageEventArgs)
        {
            _log.Debug(String.Format("RecordMessageEvent:TaskId[{0}]\r\n Message:{1}", messageEventArgs.Id, messageEventArgs.Message));
            if (textBoxLog.InvokeRequired)
            {
                textBoxLog.Invoke((MethodInvoker)(() =>
                {
                    textBoxLog.Text +=
                        String.Format(String.Format("TaskId[{0}]\r\n Message:{1}\r\n\r\n", messageEventArgs.Id,
                            messageEventArgs.Message));
                    if (textBoxLog.Text.Length > 0)
                    {
                        textBoxLog.SelectionStart = textBoxLog.Text.Length;
                    }
                    textBoxLog.ScrollToCaret();
                }));
            }
            else
            {
                textBoxLog.Text +=
                    String.Format(String.Format("TaskId[{0}]\r\n Message:{1}\r\n\r\n", messageEventArgs.Id,
                        messageEventArgs.Message));
                if (textBoxLog.Text.Length > 0)
                {
                    textBoxLog.SelectionStart = textBoxLog.Text.Length;
                }
                textBoxLog.ScrollToCaret();
            }
        }



        private void test()
        {
            //List<string> macs = new List<string>();
            //NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            //StringBuilder builder=new StringBuilder();
            //foreach (NetworkInterface ni in interfaces)
            //{
            //    macs.Add(ni.GetPhysicalAddress().ToString());
            //    builder.Append(ni.Name);
            //    builder.Append("\n\r");
            //    builder.Append(ni.NetworkInterfaceType.ToString());
            //    builder.Append("\n\r");
            //    builder.AppendFormat(String.Format("Description:[{0}]\n\rMac:[{1}]\n\rOperationalStatus:{2}\n\r", ni.Description, ni.GetPhysicalAddress(), ni.OperationalStatus.ToString()));
            //    builder.Append("\n\r");
            //}
            //MessageBox.Show(builder.ToString(), "Tip", MessageBoxButtons.OK);
            List<string> macs = new List<string>();
            StringBuilder builder = new StringBuilder();
            try
            {
                string mac = "";
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"])
                    {
                        mac = mo["MacAddress"].ToString();
                        macs.Add(mac);
                        builder.AppendFormat("{0}\r\n", mac);
                    }
                }
                moc = null;
                mc = null;
            }
            catch
            {
            }
            MessageBox.Show(builder.ToString(), "Tip", MessageBoxButtons.OK);
        }
        #endregion

        #region Controls Event
        private void FormCapture_Load(object sender, EventArgs e)
        {
            InitLoad();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        } 
        private void comboBoxConfig_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomerConfigModel model = comboBoxConfig.SelectedItem as CustomerConfigModel;
            textBoxUser.Text = model.AC;
            textBoxPassword.Text = model.PW;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CustomerConfigModel model = comboBoxConfig.SelectedItem as CustomerConfigModel;
            btnStart.Enabled = false;
            Dictionary<Guid, TaskProcessor> tasks=new Dictionary<Guid, TaskProcessor>();
            for (Int32 i = 0; i < 10; i++)
            {
                Guid id = Guid.NewGuid();
                //tasks.Add(id,new TaskBaiduPan()
                //{
                //    TaskId =id
                //});
                tasks.Add(id,new TaskIPlaySoft()
                {
                    TaskId = id,
                    Model = model,
                    PageNum = i
                });
            }
            MultithreadingServices services= MultithreadingServices.Instance().Assignment(tasks);
            services.RecordMessageEvent += services_RecordMessageEvent;
            services.Start();
            btnPause.Enabled = true;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            MultithreadingServices.Instance().End();
            btnStart.Enabled = true;
            btnPause.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Text = btnPause.Text.Equals("暂停") ? "继续" : "暂停";
            MultithreadingServices.Instance().Pause();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            List<ThreadSimpleInformation> list = MultithreadingServices.Instance().Summary();
            foreach (ThreadSimpleInformation information in list)
            {
                textBoxSummary.Text +=
                    String.Format(
                        "Thread[{0}] Started at{1},the lasted stop was at {2},until now total run times is {3}\r\n",
                        information.Id, information.StartTime, information.LastedStopTime, information.ExecutionTimes);
                textBoxSummary.Text += "\r\n";
            }
            if (textBoxSummary.Text.Length > 0)
            {
                textBoxSummary.SelectionStart = textBoxSummary.Text.Length;
            }
            textBoxSummary.ScrollToCaret();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //CustomerConfigModel configmodel = comboBoxConfig.SelectedItem as CustomerConfigModel;
            //ExWebClientLib client=new ExWebClientLib();
            //UserOperLogModel model = new UserOperLogModel();
            //ILog log = LogManager.GetLogger("OperInfoLogger");
            //log.Debug(model);
            //TaskResultLogModel tmodel = new TaskResultLogModel();
            //ILog tlog = LogManager.GetLogger("TaskResultLogger");
            //tlog.Debug(tmodel);
            ILog log = LogManager.GetLogger("TaskLogDetailLogger");
            TaskLogDetailModel model = new TaskLogDetailModel();
            log.Debug(model);
        }
        #endregion

       

        

    }
}
