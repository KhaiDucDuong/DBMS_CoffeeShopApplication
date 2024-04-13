using System;
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
        public Header()
        {
            InitializeComponent();
        }

        private void pbProduct_Click(object sender, EventArgs e)
        {

        }

        private void pbEmployee_Click(object sender, EventArgs e)
        {

        }

        private void pbOrder_Click(object sender, EventArgs e)
        {

        }

        private void pbRestockOrder_Click(object sender, EventArgs e)
        {

        }

        private void pbInventory_Click(object sender, EventArgs e)
        {

        }

        private void pbProduct_MouseHover(object sender, EventArgs e)
        {
            pbProduct.BackColor = Color.White;
            pbProduct.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbEmployee_MouseHover(object sender, EventArgs e)
        {
            pbEmployee.BackColor = Color.White;
            pbEmployee.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbOrder_MouseHover(object sender, EventArgs e)
        {
            pbOrder.BackColor = Color.White;
            pbOrder.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbRestockOrder_MouseHover(object sender, EventArgs e)
        {
            pbRestockOrder.BackColor = Color.White;
            pbRestockOrder.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbInventory_MouseHover(object sender, EventArgs e)
        {
            pbInventory.BackColor = Color.White;
            pbInventory.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbProduct_MouseLeave(object sender, EventArgs e)
        {
            pbProduct.BackColor = Color.Transparent;
            pbProduct.BorderStyle = BorderStyle.None;
        }

        private void pbEmployee_MouseLeave(object sender, EventArgs e)
        {
            pbEmployee.BackColor = Color.Transparent;
            pbEmployee.BorderStyle = BorderStyle.None;
        }

        private void pbOrder_MouseLeave(object sender, EventArgs e)
        {
            pbOrder.BackColor = Color.Transparent;
            pbOrder.BorderStyle = BorderStyle.None;
        }

        private void pbRestockOrder_MouseLeave(object sender, EventArgs e)
        {
            pbRestockOrder.BackColor = Color.Transparent;
            pbRestockOrder.BorderStyle = BorderStyle.None;
        }

        private void pbInventory_MouseLeave(object sender, EventArgs e)
        {
            pbInventory.BackColor = Color.Transparent;
            pbInventory.BorderStyle = BorderStyle.None;
        }
    }
}
