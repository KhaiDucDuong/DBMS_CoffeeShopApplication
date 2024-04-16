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
    public partial class ShopRestockBillsForm : Form
    {
        private Point[] componentLocations;
        private Size pbSize;
        private ShopRestockBillDetailsForm restockBillDetailsForm;
        public ShopRestockBillsForm()
        {
            InitializeComponent();
            componentLocations = new Point[5];
        }

        private void ShopRestockBillsForm_Load(object sender, EventArgs e)
        {
            DataSet restockBillDataSet = RestockBillBL.getAllRestockBills();
            dgvRestockBills.DataSource = restockBillDataSet.Tables[0].DefaultView;
            componentLocations[0] = pbSearch.Location;
            componentLocations[1] = pbAdd.Location;
            componentLocations[2] = pbSave.Location;
            componentLocations[3] = pbDelete.Location;
            componentLocations[4] = pbRefresh.Location;
            pbSize = pbSearch.Size;
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Length > 0)
            {
                restockBillDetailsForm = new ShopRestockBillDetailsForm(tbId.Text, dtpRestockBill.Value.ToString());
                restockBillDetailsForm.Show();
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            String date, suppliername;
            date = dtpRestockBill.Value.ToString("MM/dd/yyyy");
            suppliername = tbSupplierName.Text;
            if (RestockBillBL.addRestockBill(date, suppliername))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet productDataSet = RestockBillBL.getAllRestockBills();
                dgvRestockBills.DataSource = productDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length > 0)
            {
                DataSet restockBillDataSet = RestockBillBL.findRestockBillById(tbSearch.Text);
                dgvRestockBills.DataSource = restockBillDataSet.Tables[0].DefaultView;
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet restockBillDataSet = RestockBillBL.getAllRestockBills();
            dgvRestockBills.DataSource = restockBillDataSet.Tables[0].DefaultView;
        }

        private void dgvRestockBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvRestockBills.Rows[e.RowIndex];
                tbId.Text = row.Cells[0].Value.ToString();
                dtpRestockBill.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                tbSupplierName.Text = row.Cells[2].Value.ToString();
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            String restockBillId, date, supplierName;
            restockBillId = tbId.Text;
            date = dtpRestockBill.Value.ToString("MM/dd/yyyy");
            supplierName = tbSupplierName.Text;
            if (RestockBillBL.updateRestockBill(restockBillId, date, supplierName))
            {
                MessageBox.Show("Updated a row successfully!", "Action result");
                DataSet productDataSet = RestockBillBL.getAllRestockBills();
                dgvRestockBills.DataSource = productDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Length == 0)
                return;

            String restockBillId;
            restockBillId = tbId.Text;

            if (MessageBox.Show("Are you sure you want to delete this restockBill (id: " + tbId.Text + ") ? All of the details of the bill will be deleted as well!", "Delete Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (RestockBillBL.deleteRestockBill(restockBillId))
                {
                    MessageBox.Show("Deleted a row successfully!", "Action result");
                    DataSet restockBillDataSet = RestockBillBL.getAllRestockBills();
                    dgvRestockBills.DataSource = restockBillDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to delete a row! Check your input data!", "Action result");
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
    }
}
