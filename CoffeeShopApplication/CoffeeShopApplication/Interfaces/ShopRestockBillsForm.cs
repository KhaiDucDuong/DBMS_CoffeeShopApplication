using CoffeeShopApplication.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApplication.Interfaces
{
    public partial class ShopRestockBillsForm : Form
    {
        public ShopRestockBillsForm()
        {
            InitializeComponent();
        }

        private void ShopRestockBillsForm_Load(object sender, EventArgs e)
        {
            DataSet restockBillDataSet = RestockBillBL.getAllRestockBills();
            dgvRestockBills.DataSource = restockBillDataSet.Tables[0].DefaultView;
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {

        }

        private void pbAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
