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
    public class ProductBL
    {
        public static DataSet getAllProducts()
        {
            String str = "Select * from Product";
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, null);
            return ds;
        }

        public static DataSet findProductsByName(String productName)
        {
            String str = "SELECT * FROM dbo.FindProductByNameFunction(@productName)";
            SqlParameter productNameParam = new SqlParameter("@productName", productName);
            SqlParameter[] parameters = { productNameParam };
            /*SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.FindProductByNameFunction(@productName)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@productName", productName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");*/
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, parameters);
            return ds;
        }
    }
}
