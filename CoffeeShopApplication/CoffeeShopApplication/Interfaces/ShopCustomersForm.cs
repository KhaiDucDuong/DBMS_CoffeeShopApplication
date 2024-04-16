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
    public partial class ShopCustomersForm : Form
    {
        public ShopCustomersForm()
        {
            InitializeComponent();
        }
        private void ShopCustomersForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            DataSet customerDataSet = CustomerBL.getAllCustomers();
            dgvCustomers.DataSource = customerDataSet.Tables[0].DefaultView;
        }
        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length > 0)
            {
                DataSet customerDataSet = CustomerBL.findCustomerByPhoneNumber(tbSearch.Text);
                dgvCustomers.DataSource = customerDataSet.Tables[0].DefaultView;
            }
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            String customerName, phoneNumber;
            customerName = tbName.Text;
            phoneNumber = tbPhoneNumber.Text;
            if (CustomerBL.addCustomer(customerName, phoneNumber))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet productDataSet = CustomerBL.getAllCustomers();
                dgvCustomers.DataSource = productDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            String customerId, customerName, phoneNumber, isDeleted;
            customerId = tbId.Text;
            customerName = tbName.Text;
            phoneNumber = tbPhoneNumber.Text;
            isDeleted = cbDeleted.Text;
            if (CustomerBL.updateCustomer(customerId, customerName, phoneNumber, isDeleted == "Yes"))
            {
                MessageBox.Show("Updated a row successfully!", "Action result");
                DataSet productDataSet = CustomerBL.getAllCustomers();
                dgvCustomers.DataSource = productDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet customerDataSet = CustomerBL.getAllCustomers();
            dgvCustomers.DataSource = customerDataSet.Tables[0].DefaultView;
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            String customerId;
            customerId = tbId.Text;

            if (MessageBox.Show("Are you sure you want to delete customer " + tbName.Text + " (id: " + customerId + ")?", "Delete Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (CustomerBL.deleteCustomer(customerId))
                {
                    MessageBox.Show("Deleted a row successfully!", "Action result");
                    DataSet productDataSet = CustomerBL.getAllCustomers();
                    dgvCustomers.DataSource = productDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to delete a row! Check your input data!", "Action result");
            }
        }
        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCustomers.Rows[e.RowIndex];
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbPhoneNumber.Text = row.Cells[2].Value.ToString();

                switch (row.Cells[4].Value)
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
            pbSearch.Size = new Size(65, 65);
            pbSearch.Location = new Point(588, 283);
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(55, 55);
            pbSearch.Location = new Point(588, 293);
        }

        private void pbAdd_MouseHover(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(65, 65);
            pbAdd.Location = new Point(684, 283);
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(55, 55);
            pbAdd.Location = new Point(684, 293);
        }

        private void pbSave_MouseHover(object sender, EventArgs e)
        {
            pbSave.Size = new Size(65, 65);
            pbSave.Location = new Point(778, 283);
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Size = new Size(55, 55);
            pbSave.Location = new Point(778, 293);
        }

        private void pbRefresh_MouseHover(object sender, EventArgs e)
        {
            pbRefresh.Size = new Size(65, 65);
            pbRefresh.Location = new Point(967, 283);
        }

        private void pbRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.Location = new Point(967, 293);
        }

        private void pbDelete_MouseHover(object sender, EventArgs e)
        {
            pbDelete.Size = new Size(65, 65);
            pbDelete.Location = new Point(876, 283);
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            pbDelete.Size = new Size(55, 55);
            pbDelete.Location = new Point(876, 293);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
