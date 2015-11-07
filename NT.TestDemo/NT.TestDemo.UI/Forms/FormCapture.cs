using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NT.TestDemo.BLL.Lib;
using NT.TestDemo.Common.Helper;
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

        private void Test()
        {
            //DalTestAction action=new DalTestAction();
            //action.BatchSqlTest();
            
        }

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
            for (Int32 i = 0; i < 20; i++)
            {
                Guid id = Guid.NewGuid();
                //tasks.Add(id,new TaskBaiduPan()
                //{
                //    TaskId =id
                //});
                //tasks.Add(id,new TaskIPlaySoft()
                //{
                //    TaskId = id,
                //    Model = model,
                //    PageNum = i
                //});
                TaskSchAir task=new TaskSchAir();
                task.ConfigModel = model;
                task.ManualHandler=(SchAirlineWBMHandler)model.ManualHandler;
                task.SingleModel = new SchAirlineQueryJsonModel()
                {
                    AVType = 0,
                    AirlineType = "Single",
                    BuyerType = "1",
                    CardFlag = "",
                    Flag = "",
                    IsFixedCabin = false,
                    RouteList = new List<SchAirlineQueryJsonRouteModel>()
                    {
                        new SchAirlineQueryJsonRouteModel()
                        {
                            DesCity = "PVG",
                            DesCityName = "上海浦东",
                            FlightDate = "2015-12-14",
                            OrgCity = "CKG",
                            OrgCityName = "重庆",
                            RouteIndex = 1,
                            RouteName = "单    程"
                        }
                    }
                };
                tasks.Add(id, task);
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
            _log.Debug("开始转入登录页面.....");
            CustomerConfigModel configmodel = comboBoxConfig.SelectedItem as CustomerConfigModel;
            FormLoginWebBrowser formLoginWebBrowser=new FormLoginWebBrowser();
            formLoginWebBrowser.ConfigModel = configmodel;
            formLoginWebBrowser.TopLevel = false;
            formLoginWebBrowser.WindowState=FormWindowState.Maximized;
            formLoginWebBrowser.Dock=DockStyle.Fill;
            formLoginWebBrowser.MessageHandler += formLoginWebBrowser_MessageHandler;
            tabPageBrowser.Controls.Clear();
            tabPageBrowser.Controls.Add(formLoginWebBrowser);
            tabInformation.SelectTab(tabPageBrowser);
            formLoginWebBrowser.Show();

        }

        void formLoginWebBrowser_MessageHandler(object sender, Events.MessageEventArgs messageEventArgs)
        {
            CustomerConfigModel configmodel = comboBoxConfig.SelectedItem as CustomerConfigModel;
            configmodel.ManualHandler=sender;
        }
        #endregion

        private String _json = "";
        private void btnTest_Click(object sender, EventArgs e)
        {
            //String ss = Base64Encode("LFWX1208");
            //JsonTest();
            FormJsonToClass fomrJsonToClass = new FormJsonToClass();
            fomrJsonToClass.Show();
        }

        private string Base64Encode(string str)
        {
            var barray = Encoding.Default.GetBytes(str);
            return Convert.ToBase64String(barray);
        }

        private void JsonTest()
        {
            if (String.IsNullOrEmpty(_json))
            {
                String path = Application.StartupPath + "\\Res\\Json.txt";
                if (File.Exists(path))
                {
                    _json = File.ReadAllText(path);
                    string str = _json;
                    JsonTest();
                }
            }
            else
            {
                try
                {
                    SchAilrLineJsonModel informationModel = new SchAilrLineJsonModel();
                    informationModel = JsonConvert.DeserializeObject<SchAilrLineJsonModel>(_json);
                    informationModel.AirlineListJSONModel =JsonConvert.DeserializeObject<AirlineListJSONModel>(informationModel.AirlineListJSON);
                }
                catch (Exception ex)
                {
                    _log.Debug(ex);
                }
            }
        }

       

        
    }
}
