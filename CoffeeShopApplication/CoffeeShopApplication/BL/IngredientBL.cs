using System;
using System.Collections.Generic;
using CoffeeShopApplication.DB;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CoffeeShopApplication.BL
{
    public class IngredientBL
    {
        public static DataSet getAllIngredients()
        {
            String str = "Select * from Ingredient";
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, null);
            return ds;
        }

        public static DataSet findIngredientsByName(String ingredientName)
        {
            String str = "SELECT * FROM dbo.FindIngredientByNameFunction(@ingredientName)";
            SqlParameter ingredientNameParam = new SqlParameter("@ingredientName", ingredientName);
            SqlParameter[] parameters = { ingredientNameParam };
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, parameters);
            return ds;
        }
    }
}
