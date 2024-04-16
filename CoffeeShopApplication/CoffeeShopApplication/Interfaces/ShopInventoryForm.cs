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
    public partial class ShopInventoryForm : Form
    {
        private Point[] componentLocations;
        private Size pbSize;
        public ShopInventoryForm()
        {
            InitializeComponent();
            componentLocations = new Point[5];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShopInventoryForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            DataSet inventoryDataSet = InventoryBL.getAllInventory();
            dgvInventory.DataSource = inventoryDataSet.Tables[0].DefaultView;
            componentLocations[0] = pbSearch.Location;
            componentLocations[1] = pbAdd.Location;
            componentLocations[2] = pbSave.Location;
            componentLocations[3] = pbDelete.Location;
            componentLocations[4] = pbRefresh.Location;
            pbSize = pbSearch.Size;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length > 0)
            {
                DataSet inventoryDataSet = InventoryBL.findInventoryByName(tbSearch.Text);
                dgvInventory.DataSource = inventoryDataSet.Tables[0].DefaultView;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            String inventoryName;
            inventoryName = tbName.Text;
            if (InventoryBL.addInventory(inventoryName))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet productDataSet = InventoryBL.getAllInventory();
                dgvInventory.DataSource = productDataSet.Tables[0].DefaultView;
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            String inventoryId, inventoyName, isDeleted;
            inventoryId = tbId.Text;
            inventoyName = tbName.Text;
            isDeleted = cbDeleted.Text;
            if (InventoryBL.updateInventory(inventoryId, inventoyName, isDeleted == "Yes"))
            {
                MessageBox.Show("Updated a row successfully!", "Action result");
                DataSet productDataSet = InventoryBL.getAllInventory();
                dgvInventory.DataSource = productDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet productDataSet = InventoryBL.getAllInventory();
            dgvInventory.DataSource = productDataSet.Tables[0].DefaultView;
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            String inventoryId;
            inventoryId = tbId.Text;

            if (MessageBox.Show("Are you sure you want to delete inventory " + tbName.Text + " (id: " + inventoryId + ")?", "Delete Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (InventoryBL.deleteInventory(inventoryId))
                {
                    MessageBox.Show("Deleted a row successfully!", "Action result");
                    DataSet productDataSet = InventoryBL.getAllInventory();
                    dgvInventory.DataSource = productDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to delete a row! Check your input data!", "Action result");
            }
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvInventory.Rows[e.RowIndex];
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                switch (row.Cells[1].Value)
                {
                    case true:
                        cbDeleted.SelectedIndex = 0;
                        break;
                    case false:
                        cbDeleted.SelectedIndex = 1;
                        break;
                    default:
                        break;
                }
            }
        }

        private void pbSearch_MouseHover(object sender, EventArgs e)
        {
            pbSearch.Size = pbSize + (new Size(10, 10));
            pbSearch.Location = new Point(componentLocations[0].X, componentLocations[0].Y - 10);
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            pbSearch.Size = pbSize;
            pbSearch.Location = componentLocations[0];
        }

        private void pbAdd_MouseHover(object sender, EventArgs e)
        {
            pbAdd.Size = pbSize + (new Size(10, 10));
            pbAdd.Location = new Point(componentLocations[1].X, componentLocations[1].Y - 10);
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbAdd.Size = pbSize;
            pbAdd.Location = componentLocations[1];
        }

        private void pbSave_MouseHover(object sender, EventArgs e)
        {
            pbSave.Size = pbSize + (new Size(10, 10));
            pbSave.Location = new Point(componentLocations[2].X, componentLocations[2].Y - 10);
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Size = pbSize;
            pbSave.Location = componentLocations[2];
        }

        private void pbRefresh_MouseHover(object sender, EventArgs e)
        {
            pbRefresh.Size = pbSize + (new Size(10, 10));
            pbRefresh.Location = new Point(componentLocations[4].X, componentLocations[4].Y - 10);
        }

        private void pbRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbRefresh.Size = pbSize;
            pbRefresh.Location = componentLocations[4];
        }

        private void pbDelete_MouseHover(object sender, EventArgs e)
        {
            pbDelete.Size = pbSize + (new Size(10, 10));
            pbDelete.Location = new Point(componentLocations[3].X, componentLocations[3].Y - 10);
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            pbDelete.Size = pbSize;
            pbDelete.Location = componentLocations[3];
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
