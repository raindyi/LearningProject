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
using log4net;
using Newtonsoft.Json;
using  System.IO;

namespace NT.TestDemo.UI.Forms
{
    public partial class FormJsonToClass : Form
    {
        private ILog _log = LogManager.GetLogger(typeof(FormJsonToClass));
        private String _defgs = "{get;set;}";
        private List<String> _classNameList = new List<String>();
        public FormJsonToClass()
        {
            InitializeComponent();
            textBoxSource.MaxLength = Int32.MaxValue;
        }

        private void btnJsonToClass_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSource.Text))
            {
                Thread thread = new Thread(new ParameterizedThreadStart(JsonToClassThread));
                thread.Start(textBoxSource.Text);
            }
        }

        private void JsonToClassThread(object jsonStr)
        {
            _log.Debug("//****Start******************************************************************************************");
            String result = JsonToClassString("NewJsonClass", jsonStr.ToString());
            result = "\r\nnamespace {\r\n" + result + "\r\n}";
            SetResult(result);
            //_log.Debug(result);
            _log.Debug("//****Finish******************************************************************************************");
            MessageBox.Show("Finish");
            Thread.CurrentThread.Abort();
        }

        private void SetResult(String result)
        {
            if (textBoxResult.InvokeRequired)
            {
                textBoxResult.Invoke((MethodInvoker) (() =>
                {
                    textBoxResult.Text = result;
                }));
            }
            else
            {
                textBoxResult.Text = result;
            }
        }

        private String JsonToClassString(String cName, String jsonStr)
        {
            Boolean flag = false;
            String result = "";
            try
            {
                flag = false;
                Object obj = JsonConvert.DeserializeObject(jsonStr);
                StringBuilder classbulider = new StringBuilder();
                Dictionary<String, String> children = new Dictionary<String, String>();
                classbulider.AppendFormat("\r\npublic class {0} {1}", cName, "{ \r\n");
                object anlyobj = null;
                if (obj.GetType().Equals(typeof(Newtonsoft.Json.Linq.JObject)))
                {
                    anlyobj = obj;
                }
                else if (obj.GetType().Equals(typeof(Newtonsoft.Json.Linq.JArray)))
                {
                    var arr = ((Newtonsoft.Json.Linq.JArray)(obj));
                    if (arr.Count > 0)
                    {
                        anlyobj = arr[0];
                        flag = true;
                    }
                }
                if (anlyobj != null)
                {
                    foreach (var child in ((Newtonsoft.Json.Linq.JObject)(anlyobj)).Children())
                    {
                        //String fmt=child.ToString().Replace("\\\"","");
                        //String fmt= System.Text.RegularExpressions.Regex.Replace(child.ToString(), "\\\"", "\"");
                        String[] splits = child.ToString()
                            .Split(new string[] { "\":" }, StringSplitOptions.RemoveEmptyEntries);
                        if (splits.Length > 2)
                        {
                            classbulider.AppendFormat("\r\n/// <summary>\r\n///{0}\r\n/// </summary>", "class");
                            if (!_classNameList.Contains(child.Path))
                            {
                                _classNameList.Add(child.Path);
                                if (flag)
                                {
                                    classbulider.AppendFormat("\r\npublic List<{0}Model> {0} {1}",child.Path.Replace("[0].", ""), _defgs);
                                }
                                else
                                {
                                    classbulider.AppendFormat("\r\npublic {0}Model {0} {1}", child.Path.Replace("[0].", ""), _defgs);
                                }
                                children.Add(child.Path.Replace("[0].", "") + "Model", child.First.ToString());
                            }
                        }
                        else
                        {
                            classbulider.AppendFormat("\r\n/// <summary>\r\n///{0}\r\n/// </summary>", child.First);
                            classbulider.AppendFormat("\r\npublic object {0} {1}", child.Path.Replace("[0].", ""), _defgs);
                        }
                    }
                    classbulider.Append("\r\n}");
                    foreach (var child in children)
                    {
                        classbulider.Append(JsonToClassString(child.Key, child.Value));
                    }
                }
                result = classbulider.ToString();
            }
            catch (Exception ex)
            {
                _log.Debug(ex);
            }
            return result;
        }

        private void textBoxResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult result = saveFileDialogMain.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogMain.FileName,textBoxResult.Text,Encoding.UTF8);
            }
        }
    }
}
