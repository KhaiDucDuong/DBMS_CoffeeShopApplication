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
            if(tbSearch.Text.Length > 0)
            {
                DataSet ingredientDataSet = IngredientBL.findIngredientsByName(tbSearch.Text);
                dgvIngredients.DataSource = ingredientDataSet.Tables[0].DefaultView;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {

        }

        private void pbSave_Click(object sender, EventArgs e)
        {

        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            DataSet ingredientDataSet = IngredientBL.getAllIngredients();
            dgvIngredients.DataSource = ingredientDataSet.Tables[0].DefaultView;
        }
    }
}
