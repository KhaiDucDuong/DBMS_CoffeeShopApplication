using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CoffeeShopApplication.DB;

namespace CoffeeShopApplication.BL
{
    public class InventoryBL
    {
        public static DataSet getAllInventory()
        {
            String str = "Select * from Inventory";
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, null);
            return ds;
        }
        public static DataSet findInventoryByName(String inventoryName) {
            String str = "Select * from dbo.FindInventoryByNameFunction(@inventoryName)";
            SqlParameter inventoryNameParam = new SqlParameter("@inventoryName", inventoryName);
            SqlParameter[] parameters = { inventoryNameParam };
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, parameters);
            return ds;
        }
        public static bool addInventory(String inventoryName)
        {
            if (inventoryName == "")
                return false;

            try
            {
                String str = "InsertInventoryProc";
                SqlParameter inventoryNameParam = new SqlParameter("@inventoryName", inventoryName);
                SqlParameter[] parameters = { inventoryNameParam};
                bool commandResult = DBConnection.getInstance().ExecuteNonQuery(str, CommandType.StoredProcedure, parameters);
                return commandResult;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool updateInventory(String inventoryId, String inventoryName, bool isDeleted)
        {
            if (inventoryId == "" || inventoryName == "" || inventoryId == "")
            {
                return false;
            }
            try
            {
                String str = "UpdateInventoryProc";
                SqlParameter inventoryIdParam = new SqlParameter("@inventoryId", inventoryId);
                SqlParameter inventoryNameParam = new SqlParameter("@inventoryName", inventoryName);
                SqlParameter isDeletedParam = new SqlParameter("@isDeleted", isDeleted.ToString());
                SqlParameter[] parameters = { inventoryIdParam, inventoryNameParam, isDeletedParam };
                bool commandResult = DBConnection.getInstance().ExecuteNonQuery(str, CommandType.StoredProcedure, parameters);
                return commandResult;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public static bool deleteInventory(String inventoryId)
        {
            if (inventoryId == "")
                return false;
            try
            {
                String str = "DeleteInventoryProc";
                SqlParameter inventoryIdParam = new SqlParameter("@inventoryId", inventoryId);
                SqlParameter[] parameters = { inventoryIdParam };
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
