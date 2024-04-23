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
using CoffeeShopApplication.DB;

namespace CoffeeShopApplication.Interfaces
{
    public partial class ShopCalculateFrom : Form
    {
        public ShopCalculateFrom()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;
            decimal restockCost = CalculateRestockCost(startDate, endDate);

            decimal shopRevenue = CalculateShopRevenue(startDate, endDate);

            tbRestockCost.Text = restockCost.ToString();
            tbShopRevenue.Text = shopRevenue.ToString();
        }
      
        private decimal CalculateRestockCost(DateTime startDate, DateTime endDate)
        {
         
            string connectionString = DBConnection.getInstance().GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.CalculateRestockCostFunction(@StartDate, @EndDate)", connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    connection.Open();
                    object result = command.ExecuteScalar();

             
                    if (result != null && decimal.TryParse(result.ToString(), out decimal restockCost))
                    {
                        return restockCost;
                    }
                    else
                    {
                        return 0; 
                    }
                }
            }
        }

    
        private decimal CalculateShopRevenue(DateTime startDate, DateTime endDate)
        {
          
            string connectionString = DBConnection.getInstance().GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.CalculateShopRevenueFunction(@StartDate, @EndDate)", connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    connection.Open();
                    object result = command.ExecuteScalar();

                 
                    if (result != null && decimal.TryParse(result.ToString(), out decimal shopRevenue))
                    {
                        return shopRevenue;
                    }
                    else
                    {
                        return 0; 
                    }
                }
            }
        }
    }
}
