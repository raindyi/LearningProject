using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT.TestDemo.UI.Forms
{
    public partial class FormThreadGroup : Form
    {
        private static Thread[] _threads1 = null;
        private static Thread[] _threads2 = null;
        private static Thread[] _threads3 = null;

        private static Boolean _flag1 = false;
        private static Boolean _flag2 = false;
        private static Boolean _flag3 = false;

        private static Int32 _task1Count = 0;
        private static Int32 _task2Count = 0;
        private static Int32 _task3Count = 0;

        private static object _lockobj1=new object();
        private static object _lockobj2 = new object();
        private static object _lockobj3 = new object();

        private Queue<String> _queue1=new Queue<string>();
        private Queue<String> _queue2 = new Queue<string>();
        private Queue<String> _queue3 = new Queue<string>(); 
        public FormThreadGroup()
        {
            InitializeComponent();
        }

        #region Function
        private void Init()
        {
            Random ran=new Random();
            
            Int32 t1= ran.Next(60);
            _threads1=new Thread[t1];
            for (int i = 0; i < t1; i++)
            {
                _threads1[i]=new Thread(RunStringLog);
            }
            Int32 t2 = ran.Next(60);
            _threads2 = new Thread[t2];
            for (int i = 0; i < t1; i++)
            {
                _threads2[i] = new Thread(RunTimeLog);
            }
            Int32 t3 = ran.Next(60);
            _threads3 = new Thread[t3];
            for (int i = 0; i < t1; i++)
            {
                _threads3[i] = new Thread(RunGuidLog);
            }
        }

        private void RunStringLog()
        {
            String msg = String.Format("Thread1::{0}    {1}", "String message 4 Runing information",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        private void RunTimeLog()
        {
        }

        private void RunGuidLog()
        {
        }

        private void Log(String logMessage)
        {
            if (richTextBoxLog.InvokeRequired)
            {
                richTextBoxLog.Invoke((MethodInvoker) (() =>
                {
                    LogToTextBox(logMessage);    
                }
                    ));
            }
            else
            {
                LogToTextBox(logMessage);
            }
        }

        private void LogToTextBox(String logMessage)
        {
            richTextBoxLog.Text += String.Format("\r\n{0}\r\n",logMessage);
            richTextBoxLog.SelectionStart = richTextBoxLog.TextLength;
            richTextBoxLog.ScrollToCaret();
        }

        #endregion
        #region Controls Event
        private void buttonGroup1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGroup2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGroup3_Click(object sender, EventArgs e)
        {

        }

        private void FormThreadGroup_Load(object sender, EventArgs e)
        {
            Init();
        }
        #endregion
    }
}
