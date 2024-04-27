using CoffeeShopApplication.BL;
using CoffeeShopApplication.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String accountId = AccountBL.getAccount(tbUserName.Text, tbPassword.Text);
            if (accountId != "")
            {
                Program.loggedInEmployeeId = accountId;
                DBConnection.Username = tbUserName.Text;
                DBConnection.Password = tbPassword.Text;
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                tbUserName.Clear();
                tbPassword.Clear();
                tbUserName.Focus();
                this.Hide();
            }
            else
                MessageBox.Show("Username or password is incorrect!", "Log In Error");
        }
    }
}
