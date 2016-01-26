using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HPSocketCS;
using log4net;

namespace Lynn.SocketProject.WebApp.Page
{
    public partial class WebFormSocketTest : System.Web.UI.Page
    {
        #region Veriable

        private ILog _log = LogManager.GetLogger("MsgLogger");
        private Boolean _startState = false;
        private HPSocketCS.TcpServer _server = new TcpServer();
        private HPSocketCS.TcpClient _client=new TcpClient();
        //private Dictionary<String, ClientInformation> _dicClient = new Dictionary<String, ClientInformation>();
        #endregion

        #region Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Init();
            }
        }
        #endregion

        #region Function

        private void Init()
        {
            TextBoxServerIP.Text = "192.168.2.225";
            TextBoxServerPort.Text = "2016";
        }

        private void StartServer()
        {
            String hn = Dns.GetHostName();
            IPHostEntry entry = Dns.GetHostEntry(hn);
            foreach (var ipa in entry.AddressList)
            {
                if (!ipa.IsIPv6LinkLocal)
                {
                    _server.IpAddress = ipa.ToString();
                    break;
                }
            }
            _server.Port = (ushort) (Int32.Parse(TextBoxServerPort.Text));
            Boolean result = _server.Start();
            if (result)
            {
                LabelServerMessage.Text = "服务端启动成功";
            }
        }

        private void ClientConnect()
        {
            try
            {
                Boolean result = _client.Connetion(TextBoxServerIP.Text, (ushort)(Int32.Parse(TextBoxServerPort.Text)), false);
                if (result)
                {
                    LabelClientMessage.Text = "客户端连接成功";
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        protected void ButtonStartServer_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        protected void ButtonClientConnect_Click(object sender, EventArgs e)
        {
            ClientConnect();
        }
    }
}