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
    public partial class ShopAccountForm : Form
    {
        private Point[] componentLocations;
        private Size pbSize;
        public ShopAccountForm()
        {
            InitializeComponent();
            componentLocations = new Point[5];
        }
        private void ShopEmployeesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            DataSet accountDataSet = AccountBL.getAllAccount();
            dgvAccount.DataSource = accountDataSet.Tables[0].DefaultView;
            componentLocations[0] = pbSearch.Location;
            componentLocations[1] = pbAdd.Location;
            componentLocations[2] = pbSave.Location;
            componentLocations[3] = pbDelete.Location;
            componentLocations[4] = pbRefresh.Location;
            pbSize = pbSearch.Size;
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            String accountId, userName, employeeId, role, password, isDeleted;
            accountId = tbAccountId.Text;
            userName = tbUserName.Text;
            employeeId = tbEmployeeId.Text;
            password = tbPassword.Text;
            role = cbRole.Text;
            isDeleted = cbDeleted.Text;
            if(isDeleted != "yes")
            {
                if (AccountBL.updateAccount(employeeId, password, userName, role, "update"))
                {
                    MessageBox.Show("Updated a row successfully!", "Action result");
                    DataSet accountDataSet = AccountBL.getAllAccount();
                    dgvAccount.DataSource = accountDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
            }   
            else
            {
                if (AccountBL.updateAccount(employeeId, password, userName, role, "delete"))
                {
                    MessageBox.Show("Updated a row successfully!", "Action result");
                    DataSet accountDataSet = AccountBL.getAllAccount();
                    dgvAccount.DataSource = accountDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet accountDataSet = AccountBL.getAllAccount();
            dgvAccount.DataSource = accountDataSet.Tables[0].DefaultView;
        }
        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAccount.Rows[e.RowIndex];
                tbEmployeeId.Text = row.Cells[0].Value.ToString();
                tbAccountId.Text = row.Cells[1].Value.ToString();
                tbUserName.Text = row.Cells[2].Value.ToString();
                tbPassword.Text = row.Cells[3].Value.ToString();
                cbRole.SelectedIndex = cbRole.FindStringExact(row.Cells[4].Value.ToString()); ;

                switch (row.Cells[7].Value)
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
    }
}
