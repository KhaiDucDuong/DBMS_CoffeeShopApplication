using CoffeeShopApplication.BL;
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
            DataSet productDataSet = ProductBL.getAllProducts();
            dgvProducts.DataSource = productDataSet.Tables["Product"].DefaultView;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            DataSet productDataSet = ProductBL.findProductsByName(tbSearch.Text);
            dgvProducts.DataSource = productDataSet.Tables["Product"].DefaultView;
        }
    }
}
