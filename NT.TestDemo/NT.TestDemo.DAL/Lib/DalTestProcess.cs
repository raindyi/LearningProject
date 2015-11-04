using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace NT.TestDemo.DAL.Lib
{
    public class DalTestProcess
    {
        private ILog _log = LogManager.GetLogger(typeof(DalTestProcess));
        public Int32 BatchSqlTest()
        {
            List<String> sqls=new List<string>();
            String sql = "";
            StringBuilder builder=new StringBuilder();
            for (int i = 0; i < 20; i++)
            {
                sql = String.Format("INSERT INTO BatchTest(ID, Code, [Name], CreatedTime) VALUES (newid(), '{0}', '{1}', getdate());",
                    "Code" + i, "Name" + i);
                builder.Append(sql);
                sqls.Add(sql);
            }
            Int32 result = 0;
            using (DataBaseManager manager=new DataBaseManager())
            {
                try
                {
                    _log.Debug("Time start one and one::");
                    foreach (String sqlstr in sqls)
                    {
                        manager.Exec(sqlstr);
                    }
                    _log.Debug("Time finish one and one::");
                    _log.Debug("Time start batch::");
                    result = manager.Exec(builder.ToString());
                    _log.Debug("Time finish batch::");
                }
                catch (Exception ex)
                {
                    _log.Debug("BatchSqlTest::", ex);
                }
            }
            return result;
        }
    }
}
