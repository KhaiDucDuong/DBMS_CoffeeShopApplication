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
            SqlDataAdapter da = new SqlDataAdapter("Select * from Product", Properties.Settings.Default.DatabaseConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            return ds;
        }

        public static DataSet findProductsByName(String productName)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.FindProductByNameFunction(@productName)", conn);
            cmd.Parameters.AddWithValue("@productName", productName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            return ds;
        }
    }
}
