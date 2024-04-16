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
    public partial class ShopEmployeesForm : Form
    {
        private Point[] componentLocations;
        private Size pbSize;
        public ShopEmployeesForm()
        {
            InitializeComponent();
            componentLocations = new Point[5];
        }

        private void ShopEmployeesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            DataSet employeetDataSet = EmployeeBL.getAllEmployee();
            dgvEmployee.DataSource = employeetDataSet.Tables[0].DefaultView;
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
                DataSet employeetDataSet = CustomerBL.findCustomerByPhoneNumber(tbSearch.Text);
                dgvEmployee.DataSource = employeetDataSet.Tables[0].DefaultView;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            String fullName, phoneNumber, address, email;
            fullName = tbName.Text;
            phoneNumber = tbPhoneNumber.Text;
            address = tbAddress.Text;
            email = tbEmail.Text;
            if (EmployeeBL.addEmployee(fullName, phoneNumber, address, email, true))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet employeetDataSet = IngredientBL.getAllIngredients();
                dgvEmployee.DataSource = employeetDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            String id, fullName, phoneNumber, address, email, isDeleted;
            id = tbId.Text;
            fullName = tbName.Text;
            phoneNumber = tbPhoneNumber.Text;
            address = tbAddress.Text;
            email = tbEmail.Text;
            isDeleted = cbDeleted.Text;
            if (isDeleted != "yes")
            {
                if (EmployeeBL.updateEmployee(id, fullName, phoneNumber, address, email, false, "update"))
                {
                    MessageBox.Show("Updated a row successfully!", "Action result");
                    DataSet employeetDataSet = EmployeeBL.getAllEmployee();
                    dgvEmployee.DataSource = employeetDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
            }
            else
            {
                if (EmployeeBL.updateEmployee(id, fullName, phoneNumber, address, email, false, "delete"))
                {
                    MessageBox.Show("Updated a row successfully!", "Action result");
                    DataSet employeetDataSet = EmployeeBL.getAllEmployee();
                    dgvEmployee.DataSource = employeetDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet employeetDataSet = EmployeeBL.getAllEmployee();
            dgvEmployee.DataSource = employeetDataSet.Tables[0].DefaultView;
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvEmployee.Rows[e.RowIndex];
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbPhoneNumber.Text = row.Cells[2].Value.ToString();
                tbAddress.Text = row.Cells[3].Value.ToString();
                tbEmail.Text = row.Cells[4].Value.ToString();

                switch (row.Cells[8].Value)
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
