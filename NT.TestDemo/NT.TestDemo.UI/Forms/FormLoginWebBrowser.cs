using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using NT.TestDemo.Common.Settings;
using NT.TestDemo.Core.Model;
using NT.TestDemo.UI.Events;
using NT.TestDemo.UI.Lib;
using NT.TestDemo.UI.Model;

namespace NT.TestDemo.UI.Forms
{
    public partial class FormLoginWebBrowser : BaseForm
    {
        #region Veriable

        private CustomerConfigModel _model;
        private SchAirlineWBMHandler _handler;

        public CustomerConfigModel ConfigModel
        {
            get { return _model; }
            set { _model = value; }
        }

        private ILog _log = LogManager.GetLogger(typeof (FormLoginWebBrowser));
        
        #endregion
        #region Structure
        public FormLoginWebBrowser()
        {
            InitializeComponent();
        }
        #endregion

        

        #region Function

        private void Init()
        {
            InitControl();
            InitControlEvent();
        }

        private void InitControl()
        {
            _handler = new SchAirlineWBMHandler(webBrowserMain);
            LoginProcessModel processModel =new LoginProcessModel();
            processModel.LoginUrl =new Uri(ConfigModel.LU);
            processModel.LoginSuccessedTransforUrl = new Uri(ConfigModel.LSTU);
            processModel.ContainsCook = ConfigModel.CC;
            processModel.LoginCondition = ConfigModel.LSC;
            _handler.LoginModel = processModel;
        }

        private void InitControlEvent()
        {
            _handler.LoginEvnet += _handler_LoginEvnet;
        }

        void _handler_LoginEvnet(Common.Model.HandlingResult loginEventArgs)
        {
            _log.Debug("_handler_LoginEvnet");
            MessageEventArgs arg = new MessageEventArgs();
            if (loginEventArgs.Successed)
            {
                arg.Successed = true;
                MessageProcess(_handler, arg);
            }
        }

        

        #endregion

        #region Controls Event
        private void FormLoginWebBrowser_Load(object sender, EventArgs e)
        {
            Init();
            _handler.Login();
        }
        #endregion


    }
}
