using CoffeeShopApplication.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApplication
{
    public partial class ShopProductsForm : Form
    {
        public ShopProductsForm()
        {
            InitializeComponent();
        }

        private void ShopProductsForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            DataSet productDataSet = ProductBL.getAllProducts();
            dgvProducts.DataSource = productDataSet.Tables[0].DefaultView;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length > 0)
            {
                DataSet productDataSet = ProductBL.findProductsByName(tbSearch.Text);
                dgvProducts.DataSource = productDataSet.Tables[0].DefaultView;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            String productName, productSize, productPrice;
            productName = tbName.Text;
            productSize = cbSize.Text;
            productPrice = tbPrice.Text;
            if (ProductBL.addProduct(productName, productSize, productPrice))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet productDataSet = ProductBL.getAllProducts();
                dgvProducts.DataSource = productDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            String productId, productName, productSize, productPrice, isDeleted;
            productId = tbId.Text;
            productName = tbName.Text;
            productSize = cbSize.Text;
            productPrice = tbPrice.Text;
            isDeleted = cbDeleted.Text;
            if (ProductBL.updateProduct(productId, productName, productSize, productPrice, isDeleted == "Yes"))
            {
                MessageBox.Show("Updated a row successfully!", "Action result");
                DataSet productDataSet = ProductBL.getAllProducts();
                dgvProducts.DataSource = productDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            String productId;
            productId = tbId.Text;

            if (MessageBox.Show("Are you sure you want to delete product " + tbName.Text + " (id: " + productId + ")?", "Delete Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (ProductBL.deleteProduct(productId))
                {
                    MessageBox.Show("Deleted a row successfully!", "Action result");
                    DataSet productDataSet = ProductBL.getAllProducts();
                    dgvProducts.DataSource = productDataSet.Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Failed to delete a row! Check your input data!", "Action result");
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet productDataSet = ProductBL.getAllProducts();
            dgvProducts.DataSource = productDataSet.Tables[0].DefaultView;
        }

        private void pbSearch_MouseHover(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(65, 65);
            pbSearch.Location = new Point(588, 291);
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(55, 55);
            pbSearch.Location = new Point(588, 301);
        }

        private void pbAdd_MouseHover(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(65, 65);
            pbAdd.Location = new Point(678, 291);
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(55, 55);
            pbAdd.Location = new Point(678, 301);
        }

        private void pbSave_MouseHover(object sender, EventArgs e)
        {
            pbSave.Size = new Size(65, 65);
            pbSave.Location = new Point(772, 291);
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Size = new Size(55, 55);
            pbSave.Location = new Point(772, 301);
        }

        private void pbRefresh_MouseHover(object sender, EventArgs e)
        {
            pbRefresh.Size = new Size(65, 65);
            pbRefresh.Location = new Point(956, 291);
        }

        private void pbRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.Location = new Point(956, 301);
        }

        private void pbDelete_MouseHover(object sender, EventArgs e)
        {
            pbDelete.Size = new Size(65, 65);
            pbDelete.Location = new Point(865, 291);
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            pbDelete.Size = new Size(55, 55);
            pbDelete.Location = new Point(865, 301);
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbPrice.Text = row.Cells[3].Value.ToString();
                switch (row.Cells[2].Value.ToString())
                {
                    case "Lớn":
                        cbSize.SelectedIndex = 0;
                        break;
                    case "Vừa":
                        cbSize.SelectedIndex = 1;
                        break;
                    case "Nhỏ":
                        cbSize.SelectedIndex = 2;
                        break;
                    default:
                        break;
                }

                switch (row.Cells[6].Value)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
