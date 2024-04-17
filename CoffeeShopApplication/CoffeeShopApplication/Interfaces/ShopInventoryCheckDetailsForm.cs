using CoffeeShopApplication.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApplication.Interfaces
{
    public partial class ShopInventoryCheckDetailsForm : Form
    {
        public String checkId;
        private DataSet ingredientDataSet;
        private Point[] componentLocations;
        private Size pbSize;
        public ShopInventoryCheckDetailsForm(string checkId)
        {
            InitializeComponent();
            this.checkId = checkId;
            componentLocations = new Point[4];
        }

        private void ShopInventoryCheckDetailsForm_Load(object sender, EventArgs e)
        {
            tbCheckId.Text = checkId;
            DataSet inventoryCheckDetailsDataSet = InventoryCheckDetailsBL.findInventoryCheckDetailsById(checkId);
            dgvInventoryCheckDetails.DataSource = inventoryCheckDetailsDataSet.Tables[0].DefaultView;
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
            String ingredientId,quantity;

            if (cbIngredient.SelectedValue == null)
            {
                MessageBox.Show("Please input all the fields first!");
                return;
            }
            ingredientId = cbIngredient.SelectedValue.ToString();
            quantity = tbQuantity.Text;
            if (InventoryCheckDetailsBL.addInventoryCheckDetails(ingredientId,checkId,quantity))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet inventoryCheckDetailsDataSet = InventoryCheckDetailsBL.findInventoryCheckDetailsById(checkId);
                dgvInventoryCheckDetails.DataSource = inventoryCheckDetailsDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            String ingredientId, quantity;

            if (cbIngredient.SelectedValue == null)
            {
                MessageBox.Show("Please input all the fields first!");
                return;
            }
            ingredientId = cbIngredient.SelectedValue.ToString();
            quantity = tbQuantity.Text;
            if (InventoryCheckDetailsBL.updateInventoryCheckDetails(ingredientId, checkId, quantity))
            {
                MessageBox.Show("Update a new row successfully!", "Action result");
                DataSet inventoryCheckDetailsDataSet = InventoryCheckDetailsBL.findInventoryCheckDetailsById(checkId);
                dgvInventoryCheckDetails.DataSource = inventoryCheckDetailsDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
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
            if (MessageBox.Show("Are you sure you want to delete ingredient " + cbIngredient.Text + " from the inventory check?", "Delete Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (InventoryCheckDetailsBL.deleteInventoryCheckDetails(ingredientId, checkId))
                {
                    MessageBox.Show("Deleted a row successfully!", "Action result");
                    DataSet inventoryCheckDetailsDataSet = InventoryCheckDetailsBL.findInventoryCheckDetailsById(checkId);
                    dgvInventoryCheckDetails.DataSource = inventoryCheckDetailsDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to delete a row! Check your input data!", "Action result");
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet inventoryCheckDetailsDataSet = InventoryCheckDetailsBL.findInventoryCheckDetailsById(checkId);
            dgvInventoryCheckDetails.DataSource = inventoryCheckDetailsDataSet.Tables[0].DefaultView;
        }

        private void dgvInventoryCheckDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvInventoryCheckDetails.Rows[e.RowIndex];
                tbCheckId.Text = row.Cells[0].Value.ToString();
                cbIngredient.SelectedIndex = cbIngredient.FindStringExact(row.Cells[1].Value.ToString());
                tbQuantity.Text = row.Cells[2].Value.ToString();
            }

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
