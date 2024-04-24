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

namespace CoffeeShopApplication.Interfaces
{
    public partial class ShopInventoryCheckForm : Form
    {
        public DataSet inventoryDataSet;
        public DataSet employeeDataSet;
        private Point[] componentLocations;
        private Size pbSize;
        public ShopInventoryCheckDetailsForm inventoryCheckDetailsForm;
        public ShopInventoryCheckForm()
        {
            InitializeComponent();
            componentLocations = new Point[5];
        }
        private void ShopInventoryCheckForm_Load(object sender, EventArgs e)
        {
            dtpCheckDate.Value = DateTime.Parse(dtpCheckDate.Value.ToString());
            DataSet inventoryCheckDataSet = InventoryCheckBL.getAllInventoryCheckFromView();
            if (inventoryCheckDataSet.Tables.Count > 0)
            {
                dgvInventoryCheck.DataSource = inventoryCheckDataSet.Tables[0].DefaultView;
            }
            inventoryDataSet = InventoryBL.getAllInventory();
            cbInventory.DataSource = inventoryDataSet.Tables[0];
            cbInventory.DisplayMember = "name";
            cbInventory.ValueMember = "inventoryId";
            employeeDataSet = EmployeeBL.getAllEmployee();
            cbEmployee.DataSource = employeeDataSet.Tables[0];
            cbEmployee.DisplayMember = "fullName";
            cbEmployee.ValueMember = "employeeId";
            componentLocations[0] = pbSearch.Location;
            componentLocations[1] = pbAdd.Location;
            componentLocations[2] = pbSave.Location;
            componentLocations[3] = pbDelete.Location;
            componentLocations[4] = pbRefresh.Location;
            pbSize = pbSearch.Size;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void tbCheckId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCheckId_Click(object sender, EventArgs e)
        {

        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            DataSet inventoryCheckDataSet = InventoryCheckBL.findInventoryCheckByDateFromView(dtpSearch.Value.ToString("MM/dd/yyyy"));
            dgvInventoryCheck.DataSource = inventoryCheckDataSet.Tables[0].DefaultView;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            String checkDate, inventoryId, inventoryName, employeeId, employeeName;
            if (cbInventory.SelectedValue == null || cbEmployee.SelectedIndex == null)
            {
                MessageBox.Show("Please input all the fields first!");
                return;
            }
            checkDate = dtpCheckDate.Value.ToString("MM/dd/yyyy");
            inventoryId = cbInventory.SelectedValue.ToString();
            employeeId = cbEmployee.SelectedValue.ToString();
            if (InventoryCheckBL.addInventoryCheck(employeeId, inventoryId, checkDate))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet inventoryCheckDataSet = InventoryCheckBL.getAllInventoryCheckFromView();
                dgvInventoryCheck.DataSource = inventoryCheckDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            String checkId, checkDate, inventoryId, inventoryName, employeeId, employeeName;
            if (cbInventory.SelectedValue == null || cbEmployee.SelectedIndex == null)
            {
                MessageBox.Show("Please input all the fields first!");
                return;
            }
            checkId = tbCheckId.Text;
            checkDate = dtpCheckDate.Value.ToString("MM/dd/yyyy");
            inventoryId = cbInventory.SelectedValue.ToString();
            employeeId = cbEmployee.SelectedValue.ToString();
            if (InventoryCheckBL.updateInventoryCheck(checkId, employeeId, inventoryId, checkDate))
            {
                MessageBox.Show("Updated a new row successfully!", "Action result");
                DataSet inventoryCheckDataSet = InventoryCheckBL.getAllInventoryCheckFromView();
                dgvInventoryCheck.DataSource = inventoryCheckDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to update a row! Check your input data!", "Action result");

        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            String checkId;
            checkId = tbCheckId.Text;
            if (MessageBox.Show("Are you sure you want to delete inventory check " + tbCheckId.Text + " (id: " + checkId + ")?", "Delete Confirmation",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (InventoryCheckBL.deleteInventoryCheck(checkId))
                {
                    MessageBox.Show("Deleted a row successfully!", "Action result");
                    DataSet inventoryCheckDataSet = InventoryCheckBL.getAllInventoryCheckFromView();
                    dgvInventoryCheck.DataSource = inventoryCheckDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to delete a row! Check your input data!", "Action result");
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet inventoryCheckDataSet = InventoryCheckBL.getAllInventoryCheckFromView();
            if (inventoryCheckDataSet.Tables.Count > 0)
            {
                dgvInventoryCheck.DataSource = inventoryCheckDataSet.Tables[0].DefaultView;
            }
        }

        private void dgvInventoryCheck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvInventoryCheck.Rows[e.RowIndex];
                tbCheckId.Text = row.Cells[0].Value.ToString();
                dtpCheckDate.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                cbInventory.SelectedIndex = cbInventory.FindStringExact(row.Cells[2].Value.ToString());
                cbEmployee.SelectedIndex = cbEmployee.FindStringExact(row.Cells[3].Value.ToString());
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (tbCheckId.Text.Length > 0)
            {
                inventoryCheckDetailsForm = new ShopInventoryCheckDetailsForm(tbCheckId.Text);
                inventoryCheckDetailsForm.Show();
            }
        }
    }
}
