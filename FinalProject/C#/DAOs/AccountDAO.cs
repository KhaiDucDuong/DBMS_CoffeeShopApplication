using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject_WinForm.C_.Classes;
using Microsoft.Data.SqlClient;

namespace FinalProject_WinForm.C_.DAOs
{
    public class AccountDAO
    {
        public static Account findAccount (String username, String password)
        {
            string sqlStr = "SELECT * FROM Account WHERE username = @username AND password = @password";
            SqlParameter[] parameters = new SqlParameter[2] 
            {   new SqlParameter("username", username),
                new SqlParameter("password", password)
            };

            DataSet ds = DBConnection.getInstance().ExecuteQueryDataSet(sqlStr, CommandType.Text, parameters);
            if (ds != null)
            {
                
                try
                {
                    Account account = dataSetToAccountConverter(ds);
                    return account;
                } catch (Exception ex) { }
            }
            return null;
        }

        public static Account dataSetToAccountConverter(DataSet ds)
        {
            Account account = new Account(ds.Tables[0].Rows[0]["accountId"].ToString(),
                    ds.Tables[0].Rows[0]["employeeId"].ToString(),
                    ds.Tables[0].Rows[0]["username"].ToString(),
                    ds.Tables[0].Rows[0]["password"].ToString(),
                    ds.Tables[0].Rows[0]["role"].ToString(),
                    ds.Tables[0].Rows[0]["createdAt"].ToString(),
                    ds.Tables[0].Rows[0]["updatedAt"].ToString(),
                    ds.Tables[0].Rows[0]["isDeleted"].ToString() is "1");
            return account;
        }
    }
}
