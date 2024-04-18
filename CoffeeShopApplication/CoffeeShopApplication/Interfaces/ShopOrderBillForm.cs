using CoffeeShopApplication.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoffeeShopApplication
{
    public partial class ShopOrderBillForm : Form
    {
        private Point[] componentLocations;
        private Size pbSize;
        public ShopOrderBillForm()
        {
            InitializeComponent();
            componentLocations = new Point[5];
        }

        private void ShopOrderBillForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            DataSet orderBillDataSet = OrderBillBL.getAllOrderBill();
            dgvOrderBill.DataSource = orderBillDataSet.Tables[0].DefaultView;
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
                DataSet orderBillDataSet = OrderBillBL.findOrderBillById(tbSearch.Text);
                dgvOrderBill.DataSource = orderBillDataSet.Tables[0].DefaultView;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            String rewardPointUsed, customerId, employeeId, initialBill, finalBill;
            customerId = tbCustomerId.Text;
            employeeId = tbEmployeeId.Text;
            initialBill = tbInitialBill.Text;
            finalBill = tbFinalBill.Text;
            rewardPointUsed = tbRewardPointUsed.Text;
            if (OrderBillBL.addOrderBill(customerId, employeeId, rewardPointUsed, initialBill, finalBill))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet orderBillDataSet = OrderBillBL.getAllOrderBill();
                dgvOrderBill.DataSource = orderBillDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            String billId, rewardPointUsed, customerId, employeeId, initialBill, finalBill, isDeleted;
            billId = tbBillId.Text;
            customerId = tbCustomerId.Text;
            employeeId = tbEmployeeId.Text;
            initialBill = tbInitialBill.Text;
            finalBill = tbFinalBill.Text;
            rewardPointUsed = tbRewardPointUsed.Text;
            isDeleted = cbDeleted.Text;
            if (isDeleted != "yes")
            {
                if (OrderBillBL.updateOrderBill(customerId, employeeId, billId, rewardPointUsed, initialBill, finalBill, "update"))
                {
                    MessageBox.Show("Updated a row successfully!", "Action result");
                    DataSet orderBillDataSet = OrderBillBL.getAllOrderBill();
                    dgvOrderBill.DataSource = orderBillDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
            }
            else
            {
                if (OrderBillBL.updateOrderBill(customerId, employeeId, billId, rewardPointUsed, initialBill, finalBill, "delete"))
                {
                    MessageBox.Show("Updated a row successfully!", "Action result");
                    DataSet orderBillDataSet = OrderBillBL.getAllOrderBill();
                    dgvOrderBill.DataSource = orderBillDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet orderBillDataSet = OrderBillBL.getAllOrderBill();
            dgvOrderBill.DataSource = orderBillDataSet.Tables[0].DefaultView;
        }

        private void dgvOrderBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOrderBill.Rows[e.RowIndex];
                tbBillId.Text = row.Cells[0].Value.ToString();
                tbRewardPointUsed.Text = row.Cells[1].Value.ToString();
                tbInitialBill.Text = row.Cells[2].Value.ToString();
                tbFinalBill.Text = row.Cells[3].Value.ToString();
                tbEmployeeId.Text = row.Cells[6].Value.ToString();
                tbCustomerId.Text = row.Cells[7].Value.ToString();
                switch (row.Cells[5].Value)
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

        private void dgvOrderBill_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrderBill_CellContentClick (sender, e);
            ShopOrderBillDetailForm newForm = new ShopOrderBillDetailForm(tbBillId.Text);
            newForm.Show();
        }
    }
}
