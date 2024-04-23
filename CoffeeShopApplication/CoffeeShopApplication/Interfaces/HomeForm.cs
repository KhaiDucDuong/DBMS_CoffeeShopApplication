using CoffeeShopApplication.DB;
using CoffeeShopApplication.Interfaces;

namespace CoffeeShopApplication
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DBConnection.resetConnection();
            Program.MainForm.Show();
            this.Close();
        }
    }
}
