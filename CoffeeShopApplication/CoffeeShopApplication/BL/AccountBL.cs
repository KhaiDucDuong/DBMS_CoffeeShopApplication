using CoffeeShopApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApplication.BL
{
    public class AccountBL
    {
        public static DataSet getAllAccount()
        {
            String str = "Select * from Account";
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, null);
            return ds;
        }

        public static DataSet findAccountByUserName(string userName)
        {
            String str = "SELECT * FROM dbo.findAccountByUserNameFunction (@userName)";
            SqlParameter accountUserNameParam = new SqlParameter("@@userName", userName);
            SqlParameter[] parameters = { accountUserNameParam };
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, parameters);
            return ds;
        }

        public static string getAccount(string userName, string password)
        {
            try
            {
                string sqlStr = string.Format($"SELECT * FROM Account WHERE username = '{userName}' AND password = '{password}'");
                DataTable dtable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Properties.Settings.Default.DatabaseConnectionString);
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    return dtable.Rows[0].ItemArray[0].ToString();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi ở đây, ví dụ:
                Console.WriteLine("Error occurred while getting account: " + ex.Message);
            }
            return "";
        }

        public static bool addAccount(string employeeId, string passwords, string userName, string role)
        {
            if (employeeId == "" || passwords == "" || userName == "" || role == "")
                return false;

            try
            {
                String str = "AddAccountProc";
                SqlParameter EmployeeIdParam = new SqlParameter("@EmployeeId", employeeId);
                SqlParameter PasswordsParam = new SqlParameter("@Passwords", passwords);
                SqlParameter UserNameParam = new SqlParameter("@UserName", userName);
                SqlParameter RoleParam = new SqlParameter("@Role", role);
                SqlParameter[] parameters = { EmployeeIdParam, PasswordsParam, UserNameParam, RoleParam};
                bool commandResult = DBConnection.getInstance().ExecuteNonQuery(str, CommandType.StoredProcedure, parameters);
                return commandResult;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool updateAccount(string employeeId, string passwords, string userName, string role, string updateType)
        {
            if (employeeId == "" || passwords == "" || userName == "" || role == "")
                return false;

            try
            {
                String str = "UpdateAccountProc";
                SqlParameter EmployeeIdParam = new SqlParameter("@EmployeeId", employeeId);
                SqlParameter PasswordsParam = new SqlParameter("@Passwords", passwords);
                SqlParameter UserNameParam = new SqlParameter("@UserName", userName);
                SqlParameter RoleParam = new SqlParameter("@Role", role);
                SqlParameter UpdateTypeParam = new SqlParameter("@UpdateType", updateType);
                SqlParameter[] parameters = { EmployeeIdParam, PasswordsParam, UserNameParam, RoleParam, UpdateTypeParam };
                bool commandResult = DBConnection.getInstance().ExecuteNonQuery(str, CommandType.StoredProcedure, parameters);
                return commandResult;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
