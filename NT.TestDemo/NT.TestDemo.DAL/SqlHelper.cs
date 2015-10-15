using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using NT.TestDemo.Common.Helper;

namespace NT.TestDemo.DAL
{

    public static class SqlHelper
    {
    
        private static readonly string  ConnStr = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        //Server=.;database=xgxDB;uid=sa;pwd=123456
        //执行增删改
        public static int ExecuteNonQury(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
              DecryptAndEncryptionHelper dec = new DecryptAndEncryptionHelper();
           
            using (SqlConnection conn = new SqlConnection(dec.Decrypto(ConnStr)))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //封装一个返回单个值的
        public static object ExecuteScalar(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            DecryptAndEncryptionHelper dec = new DecryptAndEncryptionHelper(); 
            using (SqlConnection conn = new SqlConnection(dec.Decrypto(ConnStr)))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        //返回SqlDataReader对象方法
        public static SqlDataReader ExecuteReader(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            DecryptAndEncryptionHelper dec = new DecryptAndEncryptionHelper(); 
            string d = dec.Decrypto(ConnStr);
            SqlConnection conn = new SqlConnection(dec.Decrypto(ConnStr));
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = cmdType;
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    conn.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception)
                {
                    conn.Close();
                    conn.Dispose();
                    throw;
                }
            }
        }
        //封装一个返回DataTable的方法
        public static DataTable ExecuteDataTable(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            DecryptAndEncryptionHelper dec = new DecryptAndEncryptionHelper(); 
            DataTable dt = new DataTable();
            var a = dec.Decrypto(ConnStr);
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql,ConnStr))
            {
                adapter.SelectCommand.CommandType = cmdType;
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
