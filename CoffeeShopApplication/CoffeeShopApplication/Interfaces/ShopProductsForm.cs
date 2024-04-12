using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApplication
{
    public partial class ShopProductsForm : Form
    {
        public ShopProductsForm()
        {
            InitializeComponent();
        }

        private void ShopProductsForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Product", Properties.Settings.Default.DatabaseConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            dataGridView1.DataSource = ds.Tables["Product"].DefaultView;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
