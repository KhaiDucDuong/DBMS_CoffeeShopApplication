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
        private Point[] componentLocations;
        private Size pbSize;
        public ShopRestockBillDetailsForm(string restockBillId, string date)
        {
            InitializeComponent();
            this.restockBillId = restockBillId;
            this.restockBillDate = date;
            componentLocations = new Point[4];
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
            componentLocations[0] = pbAdd.Location;
            componentLocations[1] = pbSave.Location;
            componentLocations[2] = pbDelete.Location;
            componentLocations[3] = pbRefresh.Location;
            pbSize = pbAdd.Size;
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
            pbAdd.Size = pbSize + (new Size(10, 10));
            pbAdd.Location = new Point(componentLocations[0].X, componentLocations[0].Y - 10);
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbAdd.Size = pbSize;
            pbAdd.Location = componentLocations[0];
        }

        private void pbSave_MouseHover(object sender, EventArgs e)
        {
            pbSave.Size = pbSize + (new Size(10, 10));
            pbSave.Location = new Point(componentLocations[1].X, componentLocations[1].Y - 10);
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Size = pbSize;
            pbSave.Location = componentLocations[1];
        }

        private void pbRefresh_MouseHover(object sender, EventArgs e)
        {
            pbRefresh.Size = pbSize + (new Size(10, 10));
            pbRefresh.Location = new Point(componentLocations[3].X, componentLocations[3].Y - 10);
        }

        private void pbRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbRefresh.Size = pbSize;
            pbRefresh.Location = componentLocations[3];
        }

        private void pbDelete_MouseHover(object sender, EventArgs e)
        {
            pbDelete.Size = pbSize + (new Size(10, 10));
            pbDelete.Location = new Point(componentLocations[2].X, componentLocations[2].Y - 10);
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            pbDelete.Size = pbSize;
            pbDelete.Location = componentLocations[2];
        }
    }
}
