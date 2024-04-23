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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tbUserName.Clear();
            tbPassword.Clear();
            tbUserName.Focus();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            string userId = AccountBL.getAccount(tbUserName.Text, tbPassword.Text);
            if (userId != "")
            {
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountId = AccountBL.getAccount(tbUserName.Text, tbPassword.Text);
            if (accountId != "")
            {
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
        }
    }
}
