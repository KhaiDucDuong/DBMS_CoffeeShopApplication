using CoffeeShopApplication.CoffeeShopDatasetTableAdapters;
using CoffeeShopApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApplication.BL
{
    public class InventoryCheckDetails
    {
        public DataSet getAllInventoryCheckDetails()
        {
            String str = "Select * from InventoryCheckDetails";
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, null);
            return ds;
        }
        public bool addInventoryCheckDetails(string checkId, string ingredientId, int quantity)
        {
            try
            {
                string procedureName = "InsertInventoryCheckDetailsProc";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@checkId", checkId),
                    new SqlParameter("@ingredientId", ingredientId),
                    new SqlParameter("@quantity", quantity)
                };
                bool success = DBConnection.getInstance().ExecuteNonQuery(procedureName, CommandType.StoredProcedure, parameters);
                return success;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while adding inventory check details: " + ex.Message);
                return false;
            }
        }

        public bool updateInventoryCheckDetails(string checkId, string ingredientId, int quantity)
        {
            try
            {
                string procedureName = "UpdateInventoryCheckDetailsProc";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@checkId", checkId),
                    new SqlParameter("@ingredientId", ingredientId),
                    new SqlParameter("@quantity", quantity)
                };
                bool success = DBConnection.getInstance().ExecuteNonQuery(procedureName, CommandType.StoredProcedure, parameters);
                return success;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating inventory check details: " + ex.Message);
                return false;
            }
        }

        public bool deleteInventoryCheckDetails(string checkId, string ingredientId)
        {
            try
            {
                string procedureName = "DeleteInventoryCheckDetailsProc";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@checkId", checkId),
                    new SqlParameter("@ingredientId", ingredientId)
                };
                bool success = DBConnection.getInstance().ExecuteNonQuery(procedureName, CommandType.StoredProcedure, parameters);
                return success;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while deleting inventory check details: " + ex.Message);
                return false;
            }
        }

    }
}
