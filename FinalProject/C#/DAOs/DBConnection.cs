using FinalProject_WinForm.Properties;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FinalProject_WinForm
{
    class DBConnection
    {
        private static DBConnection _instance;
        private static SqlConnection conn;
        private DBConnection() {
            conn = new SqlConnection(Properties.Settings.Default.connStr);
        }
        public static DBConnection getInstance()
        {
            if (_instance == null) {
                _instance = new DBConnection();
            }
            return _instance;
        }

        public void Execute(string sqlStr, string action, SqlParameter[] parameters = null)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                // Add parameters if provided
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"{action} complete");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public List<User> LoadUser(string sqlStr, string action)
        {
            List<User> list = new List<User>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User tmp = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(5), reader.GetString(4), reader.GetInt32(6));
                    list.Add(tmp);
                }
                reader.Close();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"{action} complete");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public List<Items> LoadItem(string sqlStr, string action)
        {
            List<Items> Loadlist = new List<Items>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] imageList = new string[3];
                    imageList[0] = reader.GetString(5); // Assuming the image data is in column index 4
                    imageList[1] = reader.GetString(6); // Assuming the image data is in column index 5
                    imageList[2] = reader.GetString(7); // Assuming the image data is in column index 6

                    Items tmp = new Items(reader.GetString(1), reader.GetString(3), reader.GetInt32(2), reader.GetInt32(4), reader.GetString(10), imageList, reader.GetInt32(9), reader.GetInt32(8), reader.GetInt32(11), reader.GetInt32(12));
                    tmp.ItemId = reader.GetGuid(0).ToString();
                    Loadlist.Add(tmp);

                }
                reader.Close();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"{action} complete");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return Loadlist;
        }
        public List<OrderedItem> LoadUserCart(string sqlStr, string action)
        {
            List<OrderedItem> LoadCart = new List<OrderedItem>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OrderedItem tmp = new OrderedItem(reader.GetInt32(4), reader.GetString(0), reader.GetGuid(3).ToString(), reader.GetString(2), reader.GetInt32(1));
                    LoadCart.Add(tmp);
                }
                reader.Close();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"{action} complete");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return LoadCart;
        }

        public DataSet ExecuteQueryDataSet (string sqlStr, CommandType ct, SqlParameter[] parameters = null) {
            if(conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlStr, conn);
            comm.CommandType = ct;
            if (parameters !=  null)
                comm.Parameters.AddRange(parameters);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
