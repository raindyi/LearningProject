using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using NT.TestDemo.DAL.Lib;

namespace NT.TestDemo.BLL.Lib
{
    public class DalTestAction
    {
        private ILog _log = LogManager.GetLogger(typeof(DalTestAction));

        public Int32 BatchSqlTest()
        {
            return new DalTestProcess().BatchSqlTest();
        }
        //public DataSet Query(String sql)
        //{

        //}

        //public DataSet Query()
        //{
        //    String sql = "";
        //    return null;
        //}
    }
}
