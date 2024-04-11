using FinalProject_WinForm.C_.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_WinForm.C_.DAOs
{
    public class ProductDAO
    {
        public static List<Product> GetAllProducts() {
            List<Product> products = new List<Product>();
            string sqlStr = "SELECT * FROM Product";
            DataSet ds = DBConnection.getInstance().ExecuteQueryDataSet(sqlStr, CommandType.Text, null);
            if (ds != null)
            {
                try
                {
                    products = dataSetToProductConverter(ds);
                    return products;
                }
                catch (Exception ex) { }
            }
            return products;
        }

        public static List<Product> dataSetToProductConverter(DataSet ds)
        {
            List<Product> products = new List<Product>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                products.Add(new Product(row["productId"].ToString(),
                             row["productName"].ToString(),
                             row["productSize"].ToString(),
                             row["productPrice"].ToString(),
                             row["createdAt"].ToString(),
                             row["updatedAt"].ToString(),
                             row["isDeleted"].ToString() is "1"));
            }
            return products;
        }
    }
}
