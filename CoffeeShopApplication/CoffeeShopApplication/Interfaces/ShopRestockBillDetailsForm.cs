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
    public partial class ShopRestockBillDetailsForm : Form
    {
        private String restockBillId;
        private DataSet ingredientDataSet;
        public ShopRestockBillDetailsForm(string restockBillId)
        {
            InitializeComponent();
            this.restockBillId = restockBillId;
        }

        private void ShopRestockBillDetailsForm_Load(object sender, EventArgs e)
        {
            tbId.Text = restockBillId;
            DataSet restockBillDetailsDataSet = RestockBillDetailsBL.findRestockBillDetailsById(restockBillId);
            dgvRestockBillDetails.DataSource = restockBillDetailsDataSet.Tables[0].DefaultView;
            ingredientDataSet = IngredientBL.getAllIngredients();
            cbIngredient.DataSource = ingredientDataSet.Tables[0];
            cbIngredient.DisplayMember = "ingredientName";
            cbIngredient.ValueMember = "ingredientId";
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            String ingredientId, quantity, price;
            if (cbIngredient.SelectedValue == null)
            {
                MessageBox.Show("Please input all the fields first!");
                return;
            }

            ingredientId = cbIngredient.SelectedValue.ToString();
            quantity = tbQuantity.Text;
            price = tbPrice.Text;
            if (RestockBillDetailsBL.addRestockBillDetails(ingredientId, restockBillId, quantity, price))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet restockBillDetailsDataSet = RestockBillDetailsBL.findRestockBillDetailsById(restockBillId);
                dgvRestockBillDetails.DataSource = restockBillDetailsDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet restockBillDetailsDataSet = RestockBillDetailsBL.findRestockBillDetailsById(restockBillId);
            dgvRestockBillDetails.DataSource = restockBillDetailsDataSet.Tables[0].DefaultView;
        }
    }
}
