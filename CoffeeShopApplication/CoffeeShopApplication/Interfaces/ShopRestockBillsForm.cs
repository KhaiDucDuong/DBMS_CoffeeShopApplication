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
        private ShopRestockBillDetailsForm restockBillDetailsForm;
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
            pbSearch.Size = new Size(65, 65);
            pbSearch.Location = new Point(588, 284);
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(55, 55);
            pbSearch.Location = new Point(588, 294);
        }

        private void pbAdd_MouseHover(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(65, 65);
            pbAdd.Location = new Point(684, 284);
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(55, 55);
            pbAdd.Location = new Point(684, 294);
        }

        private void pbSave_MouseHover(object sender, EventArgs e)
        {
            pbSave.Size = new Size(65, 65);
            pbSave.Location = new Point(778, 284);
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Size = new Size(55, 55);
            pbSave.Location = new Point(778, 294);
        }

        private void pbRefresh_MouseHover(object sender, EventArgs e)
        {
            pbRefresh.Size = new Size(65, 65);
            pbRefresh.Location = new Point(971, 284);
        }

        private void pbRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.Location = new Point(971, 294);
        }

        private void pbDelete_MouseHover(object sender, EventArgs e)
        {
            pbDelete.Size = new Size(65, 65);
            pbDelete.Location = new Point(876, 284);
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            pbDelete.Size = new Size(55, 55);
            pbDelete.Location = new Point(876, 294);
        }
    }
}
