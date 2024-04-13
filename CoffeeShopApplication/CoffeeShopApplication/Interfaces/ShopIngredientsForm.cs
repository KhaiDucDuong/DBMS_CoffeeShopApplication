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
    public partial class ShopIngredientsForm : Form
    {
        public ShopIngredientsForm()
        {
            InitializeComponent();
        }

        private void ShopIngredientsForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            DataSet ingredientDataSet = IngredientBL.getAllIngredients();
            dgvIngredients.DataSource = ingredientDataSet.Tables[0].DefaultView;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length > 0)
            {
                DataSet ingredientDataSet = IngredientBL.findIngredientsByName(tbSearch.Text);
                dgvIngredients.DataSource = ingredientDataSet.Tables[0].DefaultView;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            String ingredientName, manufacturername;
            ingredientName = tbName.Text;
            manufacturername = tbManufacturerName.Text;
            if (IngredientBL.addIngredient(ingredientName, manufacturername))
            {
                MessageBox.Show("Added a new row successfully!", "Action result");
                DataSet productDataSet = IngredientBL.getAllIngredients();
                dgvIngredients.DataSource = productDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to add a row! Check your input data!", "Action result");
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            String ingredientId, ingredientName, manufacturername, isDeleted;
            ingredientId = tbId.Text;
            ingredientName = tbName.Text;
            manufacturername = tbManufacturerName.Text;
            isDeleted = cbDeleted.Text;
            if (IngredientBL.updateIngredient(ingredientId, ingredientName, manufacturername, isDeleted == "Yes"))
            {
                MessageBox.Show("Updated a row successfully!", "Action result");
                DataSet productDataSet = IngredientBL.getAllIngredients();
                dgvIngredients.DataSource = productDataSet.Tables[0].DefaultView;
            }
            else
                MessageBox.Show("Failed to update a row! Check your input data!", "Action result");
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet ingredientDataSet = IngredientBL.getAllIngredients();
            dgvIngredients.DataSource = ingredientDataSet.Tables[0].DefaultView;
        }

        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvIngredients.Rows[e.RowIndex];
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbManufacturerName.Text = row.Cells[2].Value.ToString();

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
            pbSearch.Location = new Point(652, 283);
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(55, 55);
            pbSearch.Location = new Point(652, 293);
        }

        private void pbAdd_MouseHover(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(65, 65);
            pbAdd.Location = new Point(742, 283);
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbAdd.Size = new Size(55, 55);
            pbAdd.Location = new Point(742, 293);
        }

        private void pbSave_MouseHover(object sender, EventArgs e)
        {
            pbSave.Size = new Size(65, 65);
            pbSave.Location = new Point(832, 283);
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Size = new Size(55, 55);
            pbSave.Location = new Point(832, 293);
        }

        private void pbRefresh_MouseHover(object sender, EventArgs e)
        {
            pbRefresh.Size = new Size(65, 65);
            pbRefresh.Location = new Point(921, 283);
        }

        private void pbRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbRefresh.Size = new Size(55, 55);
            pbRefresh.Location = new Point(921, 293);
        }
    }
}
