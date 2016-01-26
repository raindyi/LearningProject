using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using HPSocketCS;
using log4net;
using Lynn.SocketProject.Server.Core.Lib;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using Lynn.SocketProject.Server.Core.Model;

namespace Lynn.SocketProject.Server.UI
{
    public partial class ServerForm : Form
    {
        #region Veriable

        private ILog _log = LogManager.GetLogger("MsgLogger");
        private Boolean _startState = false;
        private AddMessageDelegate addMessage;
        private AddMessageToControlDelegate addMessageToControl;
        private AddMessageDelegate addStatusMessage;
        private UpdateDataSourceDelegate updateDataSource;
        private SetTextDelegate setText;
        private HPSocketCS.TcpServer _server = new TcpServer();
        private Dictionary<String, ClientInformation> _dicClient = new Dictionary<String, ClientInformation>();
        #endregion

        #region Structure
        public ServerForm()
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
        private void InitData()
        {
            listBoxClientList.SelectionMode=SelectionMode.MultiSimple;
            numericUpDownPort.Maximum = 9999;
            numericUpDownPort.Value = 2016;
            numericUpDownPort.Minimum = 1;
            addMessage = new AddMessageDelegate(AddMessageInvoke);
            addMessageToControl=new AddMessageToControlDelegate(AddMessageToControlInvoke);
            updateDataSource = new UpdateDataSourceDelegate(UpdateClientListInvoke);
            setText = new SetTextDelegate(SetTextInvoke);
            listBoxClientList.DataSource = _dicClient.Keys.ToList();
        }
        private void InitControl()
        {
            UpdateUi(_startState);
        }
        private void InitControlAfterData()
        {
            Closing += ServerForm_Closing;
            checkBoxGroup.CheckedChanged += CheckBoxGroup_CheckedChanged;
            richTextBoxReceiver.MouseDoubleClick += RichTextBoxReceiver_MouseDoubleClick;
            richTextBoxSender.MouseDoubleClick += RichTextBoxSender_MouseDoubleClick;
            _server.OnAccept += _server_OnAccept;
            _server.OnClose += _server_OnClose;
            _server.OnError += _server_OnError;
            _server.OnPrepareListen += _server_OnPrepareListen;
            _server.OnReceive += _server_OnReceive;
            _server.OnSend += _server_OnSend;
            _server.OnShutdown += _server_OnShutdown;
        }

        private void AddMessageToControlInvoke(RichTextBox sender, String message)
        {
            if (sender.InvokeRequired)
            {
                sender.Invoke(addMessage, message);
            }
            else
            {
                if (!String.IsNullOrEmpty(message))
                {
                    sender.Text += String.Format("[{0}]{1}\r\n", DateTime.Now.ToString("yyMMdd HH:mm:ss"), message);
                    sender.SelectionStart = richTextBoxReceiver.TextLength;
                    sender.ScrollToCaret();
                }
            }
        }
        private void AddMessageInvoke(String message)
        {
            if (richTextBoxReceiver.InvokeRequired)
            {
                richTextBoxReceiver.Invoke(addMessage, message);
            }
            else
            {
                if (!String.IsNullOrEmpty(message))
                {
                    richTextBoxReceiver.Text += String.Format("[{0}]{1}\r\n", DateTime.Now.ToString("yyMMdd HH:mm:ss"), message);
                    richTextBoxReceiver.SelectionStart = richTextBoxReceiver.TextLength;
                    richTextBoxReceiver.ScrollToCaret();
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

        private void UpdateClientListInvoke()
        {
            if (listBoxClientList.InvokeRequired)
            {
                listBoxClientList.Invoke(updateDataSource);
            }
            else
            {
                listBoxClientList.DataSource = _dicClient.Keys.ToList();
                //listBoxClientList.Refresh();
                //listBoxClientList.ResetBindings();
            }
        }
        private void SetTextInvoke(Control sender, String text, Boolean append = false)
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

        private void Start()
        {
            buttonStart.Enabled = false;
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
            _server.Port = (ushort) numericUpDownPort.Value;
            Boolean result= _server.Start();
            _startState = result;
            UpdateUi(result);
        }

        private void Stop()
        {
            if (_startState)
            {
                foreach (var ci in _dicClient.Values)
                {
                    //断开与客户端连接
                    _server.Disconnect(ci.ConnId, true);
                }
                Boolean result = _server.Stop();
                UpdateUi(!result);
            }
        }

        private void Send(ClientInformation ci, String message)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            Boolean result= _server.Send(ci.ConnId, bytes, 0, bytes.Length);
            if (result)
            {
                AddMessageToControlInvoke(richTextBoxSender,String.Format("->|{0}|\r\n{1}\r\n",ci.GetFullAddress(),message));
                SetTextInvoke(textBoxSender, "", false);
            }
        }

        private void SendGroup(List<ClientInformation> sendList, String message)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            Boolean result = false;
            Int32 cnt = 0;
            foreach (var ci in sendList)
            {
                result= _server.Send(ci.ConnId, bytes, 0, bytes.Length);
                if (result)
                {
                    cnt++;
                }
            }
            if (cnt>0)
            {
                AddMessageToControlInvoke(richTextBoxSender, String.Format("->|{0}|\r\n{1}\r\n", "群发消息", message));
                SetTextInvoke(textBoxSender, "", false);
            }
        }

        private void Receive(IntPtr connId, IntPtr pData, int length)
        {
            byte[] bytes = new byte[length];
            Marshal.Copy(pData, bytes, 0, length);
            String message = Encoding.Unicode.GetString(bytes);
            IntPtr ptr = IntPtr.Zero;
            if (_server.GetConnectionExtra(connId, ref ptr))
            {
                ClientInformation ci = (ClientInformation)Marshal.PtrToStructure(ptr, typeof(ClientInformation));
                addMessage(String.Format("|{0}|\r\n{1}\r\n", ci.GetFullAddress(), message));
            }
        }

        private void UpdateUi(Boolean startState)
        {
            buttonStart.Enabled = !startState;
            buttonStop.Enabled = startState;
            buttonSender.Enabled = startState;
            numericUpDownPort.Enabled = !startState;
        }

        private void UpdateSourceDic(ClientInformation ci, ClientConnectStateEnum connectState)
        {
            String key = String.Format("{0}:{1}", ci.IpAddress, ci.Port);
            if (connectState == ClientConnectStateEnum.Connect)
            {
                if (!_dicClient.ContainsKey(key))
                {
                    _dicClient.Add(key,ci);
                }
            }
            else
            {
                if (_dicClient.ContainsKey(key))
                {
                    _dicClient.Remove(key);
                }
            }
        }

        #endregion

        #region Event
        private HandleResult _server_OnShutdown()
        {
            return HandleResult.Ok;
        }

        private HandleResult _server_OnSend(IntPtr connId, IntPtr pData, int length)
        {
            return HandleResult.Ok;
        }

        private HandleResult _server_OnReceive(IntPtr connId, IntPtr pData, int length)
        {
            try
            {
                Receive(connId, pData, length);
                return HandleResult.Ok;
            }
            catch (Exception ex)
            {
                _log.Error("Server receive exception",ex);
                return HandleResult.Ignore;
            }
            return HandleResult.Error;
        }

        private HandleResult _server_OnPrepareListen(IntPtr soListen)
        {
            return HandleResult.Ok;
        }

        private HandleResult _server_OnError(IntPtr connId, SocketOperation enOperation, int errorCode)
        {
            _log.Error(String.Format("Server error:[{0}]",errorCode));
            return HandleResult.Ok;
        }

        private HandleResult _server_OnClose(IntPtr connId)
        {
            String connectIp = "";
            ushort connectPort = 0;
            if (_server.GetRemoteAddress(connId, ref connectIp, ref connectPort))
            {
                ClientInformation ci = new ClientInformation()
                {
                    ConnId = connId,
                    IpAddress = connectIp,
                    Port = connectPort
                };
                UpdateSourceDic(ci, ClientConnectStateEnum.Close);
                UpdateClientListInvoke();
                AddMessageToControlInvoke(richTextBoxReceiver, String.Format("|{0}| close connection",ci.GetFullAddress() ));
            }
            else
            {

            }
            return HandleResult.Ok;
        }

        private HandleResult _server_OnAccept(IntPtr connId, IntPtr pClient)
        {
            String connectIp = "";
            ushort connectPort = 0;
            ClientInformation ci = null;
            if (_server.GetRemoteAddress(connId, ref connectIp, ref connectPort))
            {
                ci = new ClientInformation()
                {
                    ConnId = connId,
                    IpAddress = connectIp,
                    Port = connectPort
                };
                UpdateSourceDic(ci, ClientConnectStateEnum.Connect);
                UpdateClientListInvoke();
                AddMessageToControlInvoke(richTextBoxReceiver,String.Format("|{0}| connected",ci.GetFullAddress()));
            }
            else
            {

            }
            if (_server.SetConnectionExtra(connId, ci))
            {
                AddMessageToControlInvoke(richTextBoxReceiver, String.Format("|{0}| setconnect success", ci.GetFullAddress()));
            }
            return HandleResult.Ok;
        }
        private void ServerForm_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void ServerForm_Closing(object sender, CancelEventArgs e)
        {
            Stop();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }
        private void buttonSender_Click(object sender, EventArgs e)
        {
            String message = textBoxSender.Text;
            List<ClientInformation> list = new List<ClientInformation>();
            foreach (var item in listBoxClientList.SelectedItems)
            {
                try
                {
                    list.Add(_dicClient[item.ToString()]);
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
            if (checkBoxGroup.Checked)
            {
                SendGroup(list,message);
            }
            else
            {
                if (list.Count > 0)
                {
                    Send(list[0], message);
                }
            }
        }
        private void CheckBoxGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGroup.Checked)
            {
                listBoxClientList.SelectionMode = SelectionMode.MultiSimple;
            }
            else
            {
                listBoxClientList.SelectionMode=SelectionMode.One;
            }
        }
        private void RichTextBoxSender_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richTextBoxSender.Clear();
        }

        private void RichTextBoxReceiver_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richTextBoxReceiver.Clear();
        }
        #endregion
    }
}
