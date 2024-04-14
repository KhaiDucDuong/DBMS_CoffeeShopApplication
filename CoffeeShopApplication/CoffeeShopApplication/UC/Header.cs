using CoffeeShopApplication.Interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApplication.UC
{
    public partial class Header : UserControl
    {
        private String topLevelForm;
        public Header()
        {
            InitializeComponent();
        }

        private void Header_Load(object sender, EventArgs e)
        {
            topLevelForm = ((Form)this.TopLevelControl).GetType().Name;
            if (topLevelForm == "HomeForm")
            {
                pbAppIcon.BackColor = Color.White;
                pbAppIcon.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (topLevelForm == "ShopIngredientsForm")
            {
                pbIngredient.BackColor = Color.White;
                pbIngredient.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (topLevelForm == "ShopProductsForm")
            {
                pbProduct.BackColor = Color.White;
                pbProduct.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (topLevelForm == "ShopEmployeesForm")
            {
                pbEmployee.BackColor = Color.White;
                pbEmployee.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (topLevelForm == "ShopRestockBillsForm")
            {
                pbRestockOrder.BackColor = Color.White;
                pbRestockOrder.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void pbAppIcon_Click(object sender, EventArgs e)
        {
            if (topLevelForm != "HomeForm")
            {
                Program.MainForm.Show();
                ((Form)this.TopLevelControl).Close();
            }
        }

        private void pbIngredient_Click(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopIngredientsForm")
            {
                ShopIngredientsForm newForm = new ShopIngredientsForm();
                newForm.Show();
                if (topLevelForm == "HomeForm")
                    ((Form)this.TopLevelControl).Hide();
                else
                    ((Form)this.TopLevelControl).Close();
            }
        }

        private void pbProduct_Click(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopProductsForm")
            {
                ShopProductsForm newForm = new ShopProductsForm();
                newForm.Show();
                if (topLevelForm == "HomeForm")
                    ((Form)this.TopLevelControl).Hide();
                else
                    ((Form)this.TopLevelControl).Close();
            }
        }

        private void pbEmployee_Click(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopEmployeesForm")
            {
                ShopEmployeesForm newForm = new ShopEmployeesForm();
                newForm.Show();
                if (topLevelForm == "HomeForm")
                    ((Form)this.TopLevelControl).Hide();
                else
                    ((Form)this.TopLevelControl).Close();
            }
        }

        private void pbOrder_Click(object sender, EventArgs e)
        {

        }

        private void pbRestockOrder_Click(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopRestockBillsForm")
            {
                ShopRestockBillsForm newForm = new ShopRestockBillsForm();
                newForm.Show();
                if (topLevelForm == "HomeForm")
                    ((Form)this.TopLevelControl).Hide();
                else
                    ((Form)this.TopLevelControl).Close();
            }
        }

        private void pbInventory_Click(object sender, EventArgs e)
        {

        }

        private void pbProduct_MouseHover(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopProductsForm")
            {
                pbProduct.BackColor = Color.White;
                pbProduct.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void pbEmployee_MouseHover(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopEmployeesForm")
            {
                pbEmployee.BackColor = Color.White;
                pbEmployee.BorderStyle = BorderStyle.FixedSingle;
            }

        }

        private void pbOrder_MouseHover(object sender, EventArgs e)
        {
            pbOrder.BackColor = Color.White;
            pbOrder.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbRestockOrder_MouseHover(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopRestockBillsForm")
            {
                pbRestockOrder.BackColor = Color.White;
                pbRestockOrder.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void pbInventory_MouseHover(object sender, EventArgs e)
        {
            pbInventory.BackColor = Color.White;
            pbInventory.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbProduct_MouseLeave(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopProductsForm")
            {
                pbProduct.BackColor = Color.Transparent;
                pbProduct.BorderStyle = BorderStyle.None;
            }
        }

        private void pbEmployee_MouseLeave(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopEmployeesForm")
            {
                pbEmployee.BackColor = Color.Transparent;
                pbEmployee.BorderStyle = BorderStyle.None;
            }
        }

        private void pbOrder_MouseLeave(object sender, EventArgs e)
        {
            pbOrder.BackColor = Color.Transparent;
            pbOrder.BorderStyle = BorderStyle.None;
        }

        private void pbRestockOrder_MouseLeave(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopRestockBillsForm")
            {
                pbRestockOrder.BackColor = Color.Transparent;
                pbRestockOrder.BorderStyle = BorderStyle.None;
            }
        }

        private void pbInventory_MouseLeave(object sender, EventArgs e)
        {
            pbInventory.BackColor = Color.Transparent;
            pbInventory.BorderStyle = BorderStyle.None;
        }

        private void pbIngredient_MouseHover(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopIngredientsForm")
            {
                pbIngredient.BackColor = Color.White;
                pbIngredient.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void pbIngredient_MouseLeave(object sender, EventArgs e)
        {
            if (topLevelForm != "ShopIngredientsForm")
            {
                pbIngredient.BackColor = Color.Transparent;
                pbIngredient.BorderStyle = BorderStyle.None;
            }
        }

        private void pbAppIcon_MouseHover(object sender, EventArgs e)
        {
            if (topLevelForm != "HomeForm")
            {
                pbAppIcon.BackColor = Color.White;
                pbAppIcon.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void pbAppIcon_MouseLeave(object sender, EventArgs e)
        {
            if (topLevelForm != "HomeForm")
            {
                pbAppIcon.BackColor = Color.Transparent;
                pbAppIcon.BorderStyle = BorderStyle.None;
            }
        }
    }
}
