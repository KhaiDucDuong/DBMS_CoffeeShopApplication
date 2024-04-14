using CoffeeShopApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApplication.BL
{
    public class RestockBillBL
    {
        public static DataSet getAllRestockBills()
        {
            String str = "Select * from RestockBill";
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, null);
            return ds;
        }

        public static bool addRestockBill(String ingredientName, string manufacturerName)
        {
            if (ingredientName == "" || manufacturerName == "")
                return false;

            try
            {
                String str = "InsertIngredientProc";
                SqlParameter ingredientNameParam = new SqlParameter("@ingredientName", ingredientName);
                SqlParameter manufacturerNameParam = new SqlParameter("@manufacturerName", manufacturerName);
                SqlParameter[] parameters = { ingredientNameParam, manufacturerNameParam };
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
