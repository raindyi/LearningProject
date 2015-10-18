using NT.MultithreadingTaskService.UI.Model;
//**********************************************
//基本配置表示层处理逻辑
//Creater Lynn
//CreatedTime 2015.10.15 14:31
//**********************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Xml;
using log4net;

namespace NT.MultithreadingTaskService.UI.Lib
{
    /// <summary>
    /// 基本配置表示层处理逻辑
    /// </summary>
    public class ConfigLib
    {
        #region Veriable

        private readonly String DefaultDirectory = String.Format("{0}\\{1}", Application.StartupPath, "Config");
        private readonly String DefaultName = "TaskInformation.config";

        private String _filepath;
        private static ConfigLib _lib = null;
        private static object _lockobj = new object();
        private ILog _log = LogManager.GetLogger(typeof(ConfigLib));
        #endregion

        #region Structure

        public ConfigLib()
        {
            _filepath = GetDefaultConfigPath();
        }

        public ConfigLib(String filepath)
        {
            _filepath = String.IsNullOrEmpty(filepath) ? GetDefaultConfigPath() : filepath;
        }

        #endregion

        #region Function

        private String GetDefaultConfigPath()
        {
            return String.Format("{0}\\{1}", DefaultDirectory, DefaultName);
        }

        public static ConfigLib Instance(String configPath)
        {

            if (_lib == null)
            {
                lock (_lockobj)
                {
                    _lib = new ConfigLib(configPath);
                }
            }
            return _lib;
        }

        public Dictionary<Guid, CustomerConfigModel> LoadConfig()
        {
            Dictionary<Guid, CustomerConfigModel> models = new Dictionary<Guid, CustomerConfigModel>();
            if (File.Exists(_filepath))
            {
                XmlDocument document = new XmlDocument();
                document.Load(_filepath);
                XmlElement element = document.DocumentElement;
                if (element.HasChildNodes)
                {
                    //<Task name="" id="8c667e69-e3c3-4008-be1d-869398db7bd4">
                    //  <AC value=""/>
                    //  <PW value=""/>
                    //  <LU value=""/>
                    //  <VCA value=""/>
                    //  <VCU value=""/>
                    //  <LoginVerication value=""/>
                    //</Task>
                    foreach (XmlNode xNode in element.ChildNodes)
                    {
                        if (xNode.NodeType.Equals(XmlNodeType.Element))
                        {
                            CustomerConfigModel model = new CustomerConfigModel();
                            if (xNode.Name.ToUpper().Equals("TASK"))
                            {
                                try
                                {
                                    model.Name = xNode.Attributes["name"].Value;
                                    model.Id = Guid.Parse(xNode.Attributes["id"].Value);
                                    if (xNode.HasChildNodes)
                                    {
                                        foreach (XmlNode cNode in xNode.ChildNodes)
                                        {
                                            if (cNode.NodeType.Equals(XmlNodeType.Element))
                                            {
                                                model.GetType()
                                                    .GetProperty(cNode.Name, BindingFlags.Instance | BindingFlags.Public)
                                                    .SetValue(model, cNode.Attributes["value"].Value);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        _log.Error(
                                            String.Format(
                                                "[E0000X002]The [TASK]contents of the config file is error:{0}",
                                                _filepath));
                                    }
                                }
                                catch (NullReferenceException nex)
                                {
                                    _log.Error("element was not exists", nex);
                                }
                                catch (FormatException fex)
                                {
                                    _log.Error("element convert error", fex);
                                }
                                catch (ArgumentException aex)
                                {
                                    _log.Error("element convert error[property type]", aex);
                                }
                            }
                            models.Add(model.Id, model);
                        }
                    }
                }
                else
                {
                    _log.Error(String.Format(
                        "[E0000X002]The [TASKINFORMATION]contents of the config file is error:{0}", _filepath));
                }
            }
            else
            {
                _log.Error(String.Format("[E0000X001]File not exists:{0}", _filepath));
            }
            return models;
        }

        #endregion
    }
}
