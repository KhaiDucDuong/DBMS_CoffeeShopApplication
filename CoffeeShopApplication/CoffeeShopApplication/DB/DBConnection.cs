using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApplication.DB
{
    public class DBConnection
    {
        private static DBConnection _instance;
        private static SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);

        private DBConnection()
        {
            conn = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
        }

        public static DBConnection getInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        public DataSet ExecuteQuery(string sqlStr, CommandType ct, SqlParameter[] parameters = null)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlStr, conn);
            comm.CommandType = ct;
            if (parameters != null)
                comm.Parameters.AddRange(parameters);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool ExecuteNonQuery(string sqlStr, CommandType ct, SqlParameter[] parameters = null)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlStr, conn);
            comm.CommandType = ct;
            if (parameters != null)
                comm.Parameters.AddRange(parameters);
            try
            {
                comm.ExecuteNonQuery();
                return true;
            } catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}