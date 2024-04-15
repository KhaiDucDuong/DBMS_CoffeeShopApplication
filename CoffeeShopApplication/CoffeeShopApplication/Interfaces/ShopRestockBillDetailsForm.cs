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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CoffeeShopApplication.Interfaces
{
    public partial class ShopRestockBillDetailsForm : Form
    {
        private String restockBillId;
        private String restockBillDate;
        private DataSet ingredientDataSet;
        public ShopRestockBillDetailsForm(string restockBillId, string date)
        {
            InitializeComponent();
            this.restockBillId = restockBillId;
            this.restockBillDate = date;
        }

        private void ShopRestockBillDetailsForm_Load(object sender, EventArgs e)
        {
            tbId.Text = restockBillId;
            dtpRestockBill.Value = DateTime.Parse(restockBillDate);
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

        private void pbDelete_Click(object sender, EventArgs e)
        {
            String ingredientId;
            if (cbIngredient.SelectedValue == null)
            {
                MessageBox.Show("Please input all the fields first!");
                return;
            }
            ingredientId = cbIngredient.SelectedValue.ToString();

            if (MessageBox.Show("Are you sure you want to delete ingredient " + cbIngredient.Text + " from the restock bill?", "Delete Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (RestockBillDetailsBL.deleteRestockBillDetails(ingredientId, restockBillId))
                {
                    MessageBox.Show("Deleted a row successfully!", "Action result");
                    DataSet restockBillDetailsDataSet = RestockBillDetailsBL.findRestockBillDetailsById(restockBillId);
                    dgvRestockBillDetails.DataSource = restockBillDetailsDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to delete a row! Check your input data!", "Action result");
            }
        }

        private void dgvRestockBillDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvRestockBillDetails.Rows[e.RowIndex];
                tbQuantity.Text = row.Cells[3].Value.ToString();
                tbPrice.Text = row.Cells[4].Value.ToString();
                cbIngredient.SelectedIndex = cbIngredient.FindStringExact(row.Cells[2].Value.ToString());
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
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
            if (RestockBillDetailsBL.updateRestockBill(ingredientId, restockBillId, quantity, price))
            {
                MessageBox.Show("Updated a row successfully!", "Action result");
                DataSet restockBillDetailsDataSet = RestockBillDetailsBL.findRestockBillDetailsById(restockBillId);
                dgvRestockBillDetails.DataSource = restockBillDetailsDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
        }

        private void pbAdd_MouseHover(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(65, 65);
            pbAdd.Location = new Point(649, 151);
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(55, 55);
            pbAdd.Location = new Point(649, 161);
        }

        private void pbSave_MouseHover(object sender, EventArgs e)
        {
            pbSave.Size = new Size(65, 65);
            pbSave.Location = new Point(743, 151);
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Size = new Size(55, 55);
            pbSave.Location = new Point(743, 161);
        }

        private void pbRefresh_MouseHover(object sender, EventArgs e)
        {
            pbRefresh.Size = new Size(65, 65);
            pbRefresh.Location = new Point(936, 151);
        }

        private void pbRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.Location = new Point(936, 161);
        }

        private void pbDelete_MouseHover(object sender, EventArgs e)
        {
            pbDelete.Size = new Size(65, 65);
            pbDelete.Location = new Point(841, 151);
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            pbDelete.Size = new Size(55, 55);
            pbDelete.Location = new Point(841, 161);
        }
    }
}
