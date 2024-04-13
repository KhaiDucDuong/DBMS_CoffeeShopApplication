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
            this.ControlBox = false;
            DataSet productDataSet = ProductBL.getAllProducts();
            dgvProducts.DataSource = productDataSet.Tables[0].DefaultView;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            DataSet productDataSet = ProductBL.findProductsByName(tbSearch.Text);
            dgvProducts.DataSource = productDataSet.Tables[0].DefaultView;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {

        }

        private void pbSearch_MouseHover(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(65, 65);
            pbSearch.Location = new Point(819, 168);
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(55, 55);
            pbSearch.Location = new Point(819, 178);
        }

        private void pbAdd_MouseHover(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(65, 65);
            pbAdd.Location = new Point(909, 168);
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(55, 55);
            pbAdd.Location = new Point(909, 178);
        }
    }
}
