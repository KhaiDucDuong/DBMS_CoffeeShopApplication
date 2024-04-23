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
        private static SqlConnection conn;
        private static String username, password;

        public static string Username { set => username = value; }
        public static string Password { set => password = value; }

        public static void resetConnection()
        {
            conn = null;
            username = null;
            password = null;
        }

        private DBConnection()
        {
            if(username != null && password != null)
                conn = new SqlConnection("Server=DESKTOP-J97NUBL;Database=CoffeeShop;User Id=" + username + ";Password=" + password + ";");
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
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
            } catch (Exception ex) { MessageBox.Show(ex.ToString(), "Connection Error"); }
            
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
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Connection Error"); }

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