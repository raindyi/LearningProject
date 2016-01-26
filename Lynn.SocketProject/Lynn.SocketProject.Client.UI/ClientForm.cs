using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HPSocketCS;
using log4net;
using Lynn.SocketProject.Client.Core.Lib;

namespace Lynn.SocketProject.Client.UI
{
    public partial class ClientForm : Form
    {
        #region Veriable

        private ILog _log = LogManager.GetLogger("MsgLogger");
        private AddMessageDelegate addMessage;
        private AddMessageDelegate addStatusMessage;
        private UpdateDataSourceDelegate updateDataSource;
        //private ClearTextDelegate clearText;
        private SetTextDelegate setText;
        private SetControlEnableDelegate setControlEnable;
        HPSocketCS.TcpClient _client = new TcpClient();
        private List<String> _listClient=new List<String>();
        private static Boolean _connectState = false;
        #endregion
        #region Structure
        public ClientForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Function
        private void Init()
        {
            InitControl();
            InitData();
            InitControlAfterData();
        }
        private void InitControl()
        {
            buttonStop.Enabled = false;
            buttonSender.Enabled = false;
            numericUpDownPort.Maximum = 9999;
            numericUpDownPort.Value = 2016;
            numericUpDownPort.Minimum = 1;
        }
        private void InitData()
        {
            //_client= new TcpClient();
            addMessage =new AddMessageDelegate(AddMessageInvoke);
            updateDataSource=new UpdateDataSourceDelegate(UpdateClientListInvoke);
            addStatusMessage=new AddMessageDelegate(AddStatusMessageInvoke);
            setControlEnable= new SetControlEnableDelegate(SetControlEnableInvoke);
            //clearText=new ClearTextDelegate(ClearTextInvoke);
            setText =new SetTextDelegate(SetTextInvoke);
        }
        private void InitControlAfterData()
        {
            Closing += ClientForm_Closing;
            richTextBoxMessage.MouseDoubleClick += RichTextBoxMessage_MouseDoubleClick;
            _client.OnPrepareConnect += _client_OnPrepareConnect;
            _client.OnConnect += _client_OnConnect;
            _client.OnClose += _client_OnClose;
            _client.OnError += _client_OnError;
            _client.OnSend += _client_OnSend;
            _client.OnReceive += _client_OnReceive;
        }

        private void AddMessageInvoke(String message)
        {
            if (richTextBoxMessage.InvokeRequired)
            {
                richTextBoxMessage.Invoke(addMessage, message);
            }
            else
            {
                if (!String.IsNullOrEmpty(message))
                {
                    richTextBoxMessage.Text += String.Format("[{0}]{1}\r\n", DateTime.Now.ToString("yyMMdd HH:mm:ss"), message);
                    richTextBoxMessage.SelectionStart = richTextBoxMessage.TextLength;
                    richTextBoxMessage.ScrollToCaret();
                }
            }
        }

        private void AddStatusMessageInvoke(String message)
        {
            if (statusStripMain.InvokeRequired)
            {
                statusStripMain.Invoke(addStatusMessage, message);
            }
            else
            {
                tsslabelMessage.Text = message;
            }
        }

        //private void ClearTextInvoke(Control sender)
        //{
        //    if (sender.InvokeRequired)
        //    {
        //        sender.Invoke(clearText,sender);
        //    }
        //    else
        //    {
        //        sender.Text = "";
        //    }
        //}

        private void UpdateClientListInvoke()
        {
            if (listBoxClientList.InvokeRequired)
            {
                listBoxClientList.Invoke(updateDataSource);
            }
            else
            {
                listBoxClientList.DataSource = _listClient;
            }
        }
        private void SetTextInvoke(Control sender,String text, Boolean append=false)
        {
            if (sender.InvokeRequired)
            {
                sender.Invoke(setText, sender, text, append);
            }
            else
            {
                if (append)
                {
                    sender.Text += text;
                }
                else
                {
                    sender.Text = text;
                }
            }
        }

        private void SetControlEnableInvoke(Control sender,Boolean enable)
        {
            if (sender.InvokeRequired)
            {
                sender.Invoke(setControlEnable, sender, enable);
            }
            else
            {
                sender.Enabled = enable;
            }
        }

        private void UpdateUi(Boolean connected)
        {
            buttonStop.Enabled = connected;
            buttonConnect.Enabled = !connected;
            textBoxServerIP.Enabled = !connected;
            numericUpDownPort.Enabled = !connected;
            buttonSender.Enabled = connected;
        }

        private void Connect()
        {
            try
            {
                _log.Debug("Client try to start...");
                //_client = new TcpClient();
                _connectState = _client.Connetion(textBoxServerIP.Text, (ushort) numericUpDownPort.Value, false);
                UpdateUi(_connectState);
            }
            catch (Exception ex)
            {
                _log.Error("Client connect exception",ex);
            }
        }

        private void Stop()
        {
            if (_connectState)
            {
                _client.Stop();
                _connectState = false;
                UpdateUi(_connectState);
            }
        }

        private void Close()
        {
            _client.Destroy();
        }

        private void Send(String message)
        {
            if (message.Length > 0)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(message);
                Boolean result = _client.Send(bytes, 0, bytes.Length);
                if (result)
                {
                    AddMessageInvoke(String.Format("{0}->",message));
                    setText(textBoxSender, "", false);
                }
            }
            else
            {
                addStatusMessage("不允许发送空消息");
            }
        }

        private void Receive(TcpClient sender, IntPtr pData, int length)
        {
            byte[] bytes = new byte[length];
            Marshal.Copy(pData, bytes, 0, length);
            String message = Encoding.Unicode.GetString(bytes);
            //String message = sender.ByteToStructure<String>(bytes);
            AddMessageInvoke(String.Format("->{0}", message));
        }

        private void Test()
        {
            buttonTest.Enabled = false;
            Thread thread=new Thread(new ThreadStart(Work));
            thread.Start();
        }

        private void Work()
        {
            Int32 i = 0;
            while (i<10000)
            {
                Send(Guid.NewGuid().ToString());
                Thread.Sleep(10);
                i++;
            }
            setControlEnable(buttonTest, true);
        }

        #endregion

        #region Event
        private void ClientForm_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void ClientForm_Closing(object sender, CancelEventArgs e)
        {
            Close();
        }
        private HandleResult _client_OnReceive(TcpClient sender, IntPtr pData, int length)
        {
            try
            {
                Receive(sender, pData, length);
            }
            catch (Exception ex)
            {
                _log.Error("Client receive exception", ex);
                return HandleResult.Ignore;
            }
            return HandleResult.Ok;
        }

        private HandleResult _client_OnSend(TcpClient sender, IntPtr pData, int length)
        {
            byte[] bytes = new byte[length];
            Marshal.Copy(pData, bytes, 0, length);
            String message = Encoding.Unicode.GetString(bytes);
            return HandleResult.Ok;
        }

        private HandleResult _client_OnError(TcpClient sender, SocketOperation enOperation, int errorCode)
        {
            return HandleResult.Ok;
        }

        private HandleResult _client_OnClose(TcpClient sender)
        {
            Stop();
            _log.Debug("Disconnecting from the server ");
            return HandleResult.Ok;
        }

        private HandleResult _client_OnConnect(TcpClient sender)
        {
            //Send("Hello we connected,呵呵");
            _log.Debug("Server connected ");
            return HandleResult.Ok;
        }

        private HandleResult _client_OnPrepareConnect(TcpClient sender, uint socket)
        {
            _log.Debug("Ready to connect...... ");
            return HandleResult.Ok;
        }
        

        private void buttonSender_Click(object sender, EventArgs e)
        {
            Send(textBoxSender.Text);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }
        private void RichTextBoxMessage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richTextBoxMessage.Clear();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Test();
        }
        #endregion
    }
}
