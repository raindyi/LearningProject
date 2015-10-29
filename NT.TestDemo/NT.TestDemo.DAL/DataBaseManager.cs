using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Configuration;
using NT.TestDemo.PL.Model;
using NT.TestDemo.Common.Helper;
using NT.TestDemo.Common.Model;
using System.Data.SqlClient;
using log4net;

namespace NT.TestDemo.DAL
{
    /// <summary>
    /// Database manager
    /// </summary>
    public class DataBaseManager:IDisposable
    {
        #region Variable
        private ILog _log=LogManager.GetLogger(typeof(DataBaseManager));
        private static DbProviderFactory _dbProviderFactory;
        private static string _providerName;
        private static string _connStr;
        private const string KEYNAME_CONNECTION = "Connection";
        private static ConnectionStringSettings _connSettings;
        /// <summary>
        /// 实例中的数据库连接
        /// </summary>
        private DbConnection _conn;

        private bool _isNewConnStr;
        private bool _isAutoCommit = false;

        private DbTransaction _trans;
        /// <summary>
        /// 当前连接是否已经在事务中。
        /// </summary>
        public bool IsInTransaction
        {
            get { return _trans != null; }
        }

        private bool _isAutoClosed = true;
        private bool _needClose;
        #endregion

        #region Construct
        /// <summary>
        /// 
        /// </summary>
        public DataBaseManager()
        {
            if (String.IsNullOrEmpty(ConfigInformation.Connectiong))
            {
                string connstr = ConfigurationManager.AppSettings.Get(KEYNAME_CONNECTION);
                var helper = new DecryptAndEncryptionHelper(ConfigInformation.Key,ConfigInformation.Vector);  
                _connStr = helper.Decrypto(connstr);
            
                ConfigInformation.Connectiong = _connStr;
            }
        }

        /// <summary>
        /// 使用System.Data.SqlClient作为数据库提供者，并使用连接字符串构造实例。
        /// </summary>
        /// <param name="connStr">数据库连接字符串。</param>
        /// <param name="providerName">[可选]数据库提供者字符串。当不提供此参数时，会使用System.Data.SqlClient作为数据库提供者。</param>
        public DataBaseManager(string connStr, string providerName = "System.Data.SqlClient")
        {
            if (String.IsNullOrEmpty(ConfigInformation.Connectiong) || !string.Equals(_providerName, providerName))
            {
                string connstr = ConfigurationManager.AppSettings.Get(KEYNAME_CONNECTION);
                DecryptAndEncryptionHelper helper = new DecryptAndEncryptionHelper();
                _connStr = helper.Decrypto(connstr);
                ConfigInformation.Connectiong = _connStr;
                _providerName = providerName;
                _isNewConnStr = true;
            }
        }


        #endregion

        #region Functions
        public HandlingResult ValidateConnection()
        {
            HandlingResult result=new HandlingResult();
                try
                {
                    Open();
                    if (IsOpened)
                    {
                        result.Successed=true;
                    }
                }
                catch (Exception e)
                {
                    _log.Error("Connect Database Error:", e);
                    result.Message = "数据库连接错误，请检查相关配置!";
                    result.Successed=false;
                }
            return result;
        }

        /// <summary>
        /// 当前连接中否是已经打开。
        /// </summary>
        public bool IsOpened
        {
            get
            {
                return _conn != null &&
                       (_conn.State == ConnectionState.Open ||
                        _conn.State == ConnectionState.Executing ||
                        _conn.State == ConnectionState.Fetching);
            }
        }

        /// <summary>
        /// 返回一个已经打开的数据库连接，参见<see cref="Open"/>方法。
        /// </summary>
        public DbConnection Connection
        {
            get { return Open(); }
        }

        /// <summary>
        /// 创建连接类的实例
        /// </summary>
        /// <returns></returns>
        public DbConnection CreateConnection()
        {
            #region commented code
            /*
			if (string.Equals(ProviderName, "System.Data.SqlClient", StringComparison.OrdinalIgnoreCase))
			{
				_conn = new SqlConnection(ConnectionString);
			}
			else if (string.Equals(ProviderName, "System.Data.OleDbClient", StringComparison.OrdinalIgnoreCase))
			{
				_conn = new OleDbConnection(ConnectionString);
			}
			else if (string.Equals(ProviderName, "System.Data.OdbcClient", StringComparison.OrdinalIgnoreCase))
			{
				_conn = new OdbcConnection(ConnectionString);
			}
			else if (string.Equals(ProviderName, "System.Data.OracleClient", StringComparison.OrdinalIgnoreCase))
			{
				_conn = new OracleConnection(ConnectionString);
				//ODP.NET
			}
			else if (string.Equals(ProviderName, "MySql.Data.MySqlClient", StringComparison.OrdinalIgnoreCase))
			{
				_conn = new MySqlConnection(ConnectionString);
				//MySqlConnector.NET
			}
			*/
            #endregion commented code

            HandleException(() =>
            {
                _conn = DbProviderFactory.CreateConnection();

                if (_conn == null)
                {
                    throw new Exception(String.Format("Can't support Provider:{0}", ProviderName));
                }
                _conn.ConnectionString = ConnectionString;
            });

            if (_conn != null)
            {
                return _conn;
            }

            throw new Exception(String.Format("Can't support Provider:{0}", ProviderName));
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        /// <remarks>
        /// 如果没有数据连接，则创建新的数据连接，并打开；如果已经有打开的数据库连接，则直接返回该连接；如果已经数据库连接，处于关闭状态，则打开该连接，并返回该连接。
        /// </remarks>
        /// <returns></returns>
        public DbConnection Open()
        {
            if (_conn == null || _isNewConnStr)
            {
                _conn = CreateConnection();
            }

            if (_conn.State == ConnectionState.Broken)
            {
                _conn.Close();
            }

            if (_conn.State == ConnectionState.Closed)
            {
                try
                {
                    _conn.Open();
                }
                catch (Exception ex)
                {
                    //TODO log
                    throw ex;
                    //throw new UnOpenConnectionException();
                }
                finally
                {

                }
            }

            return _conn;
        }

        /// <summary>
        /// 关闭数据库连接，不会抛出异常。 
        /// </summary>
        public void Close()
        {
            HandleException(
                () =>
                {
                    if (_trans != null)
                    {
                        if (!_isAutoCommit)
                        {
                            _trans.Rollback();
                        }
                        else
                        {
                            _trans.Commit();
                        }
                        _trans.Dispose();
                    }

                    _conn.Close();
                },
                false);
        }
        #endregion

        

        /// <summary>
        /// 开始一个事务
        /// </summary>
        /// <param name="isAutoClosed"></param>
        /// <returns></returns>
        public DbTransaction Begin(bool isAutoClosed = true)
        {
            _isAutoClosed = isAutoClosed;
            _needClose = !IsOpened;
            _trans = Connection.BeginTransaction();

            return _trans;
        }

        /// <summary>
        /// 提交事务
        /// </summary>
        public void Commit()
        {
            if (_trans == null)
            {
                throw new Exception("还没有开始事务，不能提交事务。");
            }

            _trans.Commit();
            _trans = null;

            if (_isAutoClosed && _needClose)
            {
                Close();
                _needClose = false;
            }
        }

        /// <summary>
        /// 回滚事务
        /// </summary>
        public void Rollback()
        {
            if (_trans == null)
            {
                throw new Exception("还没有开始事务，不能提交事务。");
            }

            _trans.Rollback();
            _trans = null;

            if (_isAutoClosed && _needClose)
            {
                Close();
                _needClose = false;
            }
        }

        /// <summary>
        /// 执行需要事务处理的代码，并可以处理异常信息。
        /// </summary>
        /// <param name="act"></param>
        /// <param name="actLog"></param>
        public void ExecTrans(Action act, Action<Exception> actLog = null)
        {
            try
            {
                Begin();
                act();
                Commit();
            }
            catch (Exception ex)
            {
                Rollback();
                if (actLog != null)
                {
                    actLog(ex);
                }
            }
        }


        #region 执行SQL语句相关

        /// <summary>
        /// 执行SQL语句，并可以使用可先的参数列表。
        /// </summary>
        /// <param name="sql">要执行的插入SQL语句。</param>
        /// <param name="dbParams">可选的参数列表。</param>
        /// <returns>执行SQL语句时有服务器上受影响的数据行数。</returns>
        public int Exec(string sql, DbParameter[] dbParams)
        {
            var cmd = Command(sql, false, dbParams);

            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 执行SQL语句，并可以使用可先的参数列表。
        /// </summary>
        /// <param name="sql">要执行的插入SQL语句。</param>
        /// <param name="vals">可选的参数值列表。</param>
        /// <returns>执行SQL语句时有服务器上受影响的数据行数。</returns>
        public int Exec(string sql, params object[] vals)
        {
            var cmd = Command(sql, false, vals);

            return cmd.ExecuteNonQuery();
        }


        public int Exec(String sql)
        {
            var cmd = DbProviderFactory.CreateCommand();
            cmd.Connection = Connection;
            cmd.Transaction = _trans;
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="dbParams"></param>
        /// <returns></returns>
        public DataSet GetTable(string sql, DbParameter[] dbParams)
        {
            var adapter = GetDataAdapter();
            var cmd = Command(sql, false, dbParams);
            adapter.SelectCommand = cmd;

            var ds = new DataSet();
            adapter.Fill(ds);

            return ds;
        }
        /// <summary>
        /// Get fata
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetDataFromSql(String sql)
        {
            var adapter = GetDataAdapter();
            adapter.SelectCommand = Command();
            DataTable dt = new DataTable();
            adapter.SelectCommand.CommandText = sql;
            adapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Get data batch
        /// </summary>
        /// <param name="sqls"></param>
        /// <returns></returns>
        public DataSet GetDataFromSql(String[] sqls)
        {
            var adapter = GetDataAdapter();
            adapter.SelectCommand = Command();
            DataSet ds = new DataSet();
            foreach (var sql in sqls)
            {
                DataTable dt = new DataTable();
                adapter.SelectCommand.CommandText = sql;
                adapter.Fill(dt);
                ds.Tables.Add(dt);
            }
            return ds;
        }

        /// <summary>
        /// With table name
        /// </summary>
        /// <param name="sqls"></param>
        /// <returns></returns>
        public DataSet GetDataFromSql(Dictionary<String, String> sqls)
        {
            var adapter = GetDataAdapter();
            adapter.SelectCommand = Command();
            DataSet ds = new DataSet();
            foreach (var sql in sqls)
            {
                DataTable dt = new DataTable();
                adapter.SelectCommand.CommandText = sql.Value;
                adapter.Fill(dt);
                dt.TableName = sql.Key;
                ds.Tables.Add(dt);
            }
            return ds;
        }

        /// <summary>
        /// Update batch with transaction
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="commandSql"></param>
        /// <returns></returns>
        public Boolean Update(DataTable dataTable, String commandSql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(commandSql, _trans.Connection as SqlConnection);
            adapter.SelectCommand = new SqlCommand(commandSql, _trans.Connection as SqlConnection, (SqlTransaction)_trans);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            Int32 result = adapter.Update(dataTable);
            return result > 0;
        }
        /// <summary>
        /// Update batch not use transaction
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="commandSql"></param>
        /// <returns></returns>
        public Boolean UpdateNoTrans(DataTable dataTable, String commandSql)
        {
            SqlDataAdapter adapter = (SqlDataAdapter)GetDataAdapter();
            adapter.SelectCommand = new SqlCommand(commandSql, (SqlConnection)Connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            Int32 result = adapter.Update(dataTable);
            return result > 0;
        }

        public Int32 ExceSpTrans(string sql, DbParameter[] dbParams)
        {
            var cmd = DbProviderFactory.CreateCommand();
            cmd.Connection = Connection;
            cmd.Transaction = _trans;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;
            if (dbParams != null && dbParams.Length > 0)
            {
                cmd.Parameters.AddRange(dbParams);
            }
            return cmd.ExecuteNonQuery();
        }

        #endregion

        #region 执行存储过程相关

        /// <summary>
        /// 执行存储过程，并可以使用可先的参数列表。
        /// </summary>
        /// <param name="spName">要执行的存储过程名称。</param>
        /// <param name="dbParams">可选的参数列表。</param>
        /// <returns>执行存储过程时有服务器上受影响的数据行数。</returns>
        public int ExecSP(string spName, DbParameter[] dbParams)
        {
            var cmd = Command(spName, true, dbParams);

            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 执行存储过程，并可以使用可先的参数列表。
        /// </summary>
        /// <param name="spName">要执行的存储过程名称。</param>
        /// <param name="vals">可选的参数值列表。</param>
        /// <returns>执行存储过程时有服务器上受影响的数据行数。</returns>
        public int ExecSP(string spName, params object[] vals)
        {
            var cmd = Command(spName, true, vals);

            return cmd.ExecuteNonQuery();
        }

        #endregion

        public DbDataAdapter GetDataAdapter()
        {
            var adapter = DbProviderFactory.CreateDataAdapter();
            return adapter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public DbParameter Param(string pName, object val)
        {
            var p = DbProviderFactory.CreateParameter();
            p.ParameterName = pName;
            p.Value = val;

            return p;
        }

        /// <summary>
        /// 根据SQL参数创建DbCommand，如果提供了isStoredProcedure参数并为True，则把SQL作为存储过程名。
        /// </summary>
        /// <param name="sql">SQL语句或存储过程名称。</param>
        /// <param name="isStoreProcedure">[可选]如果提供了此参数，且为True，则把<see cref="sql"/>参数作为存储过程名称。</param>
        /// <param name="vals"></param>
        /// <returns></returns>
        public DbCommand Command(string sql, bool isStoreProcedure = false, params object[] vals)
        {
            var cmd = DbProviderFactory.CreateCommand();
            cmd.Connection = Connection;
            cmd.Transaction = _trans;
            cmd.CommandText = sql;

            if (isStoreProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }

            if (vals != null && vals.Length > 0)
            {
                for (int j = 0; j < vals.Length; j++)
                {
                    cmd.Parameters.Add(Param("@p" + j, vals[j] ?? DBNull.Value));

                }
            }

            return cmd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isStoreProcedure"></param>
        /// <param name="dbParams"></param>
        /// <returns></returns>
        public DbCommand Command(string sql, bool isStoreProcedure = false, params DbParameter[] dbParams)
        {
            var cmd = DbProviderFactory.CreateCommand();
            cmd.Connection = Connection;
            cmd.Transaction = _trans;
            cmd.CommandText = sql;

            if (isStoreProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }

            if (dbParams != null && dbParams.Length > 0)
            {
                cmd.Parameters.AddRange(dbParams);
            }

            return cmd;
        }

        public DbCommand Command()
        {
            var cmd = DbProviderFactory.CreateCommand();
            cmd.Connection = Connection;
            cmd.Transaction = _trans;
            //cmd.CommandText = sql;
            return cmd;
        }

        public DbProviderFactory DbProviderFactory
        {
            get
            {
                return HandleException(() =>
                {
                    if (_dbProviderFactory == null || _isNewConnStr)
                    {
                        _dbProviderFactory = DbProviderFactories.GetFactory(ProviderName);
                    }

                    return _dbProviderFactory;
                });
            }
        }

        public string ProviderName
        {
            get
            {
                if (string.IsNullOrEmpty(_providerName))
                {
                    if (_connSettings == null)
                    {
                        _connSettings = ConfigurationManager.ConnectionStrings[KEYNAME_CONNECTION];
                    }

                    if (_connSettings != null)
                    {
                        _providerName = _connSettings.ProviderName;
                    }
                }

                if (string.IsNullOrEmpty(_providerName))
                {
                    _providerName = "System.Data.SqlClient";
                }

                return _providerName;
            }
            set { _providerName = value; }
        }

        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connStr))
                {
                    if (_connSettings == null)
                    {
                        _connSettings = ConfigurationManager.ConnectionStrings[KEYNAME_CONNECTION];
                    }
                    if (_connSettings != null)
                    {
                        _connStr = _connSettings.ConnectionString;
                    }
                    else
                    {
                    }
                }

                if (string.IsNullOrEmpty(_connStr))
                {
                    throw new Exception("数据库连接字符串为空，不能创建数据库连接。");
                }

                return _connStr;
            }
            set
            {
                if (!string.Equals(_connStr, value))
                {
                    _connStr = value;
                    _isNewConnStr = true;
                }
            }
        }

        private T HandleException<T>(Func<T> func, bool rethrow = true)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                if (OnError != null)
                {
                    OnError(ex);
                }
                if (rethrow)
                {
                    //_log.Error(ex);
                    throw;
                }
            }

            return default(T);
        }

        private void HandleException(Action action, bool rethrow = true)
        {
            try
            {
                try
                {
                    action();
                }
                catch (Exception ex)
                {
                    if (OnError != null)
                    {
                        OnError(ex);
                    }
                    if (rethrow)
                    {
                        throw;
                    }
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 错误日志处理委托，传入的参数是Exception。
        /// </summary>
        public static Action<Exception> OnError { get; set; }
        /// <summary>
        /// 释放数据库连接外部资源
        /// </summary>
        public void Dispose()
        {
            if (_conn != null)
            {
                if (_conn.State != ConnectionState.Closed)
                {
                    Close();
                }

                _conn.Dispose();
            }
        }
    }

    /// <summary>
    /// 未打开数据库连接异常。
    /// </summary>
    public class UnOpenConnectionException : ApplicationException
    {
        public UnOpenConnectionException(string msg)
            : base(msg)
        {
        }

        public UnOpenConnectionException()
            : base("不能打开数据库连接！")
        {
        }
    }
}
