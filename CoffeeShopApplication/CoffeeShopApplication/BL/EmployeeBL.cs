using CoffeeShopApplication.CoffeeShopDatasetTableAdapters;
using CoffeeShopApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApplication.BL
{
    public class EmployeeBL 
    { 
        public static DataSet getAllEmployee()
        {
            String str = "Select * from Employee";
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, null);
            return ds;
        }

        public static DataSet findEmployeeByName(String employeeName)
        {
            String str = "SELECT * FROM dbo.findEmployeeByNameFunction(@employeeName)";
            SqlParameter productNameParam = new SqlParameter("@employeeName", employeeName);
            SqlParameter[] parameters = { productNameParam };
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, parameters);
            return ds;
        }

        public static DataSet findEmployeeByPhoneNumber(String phoneNumber)
        {
            String str = "SELECT * FROM dbo.findCustomerByPhoneNumberFunction(@PhoneNumber)";
            SqlParameter productNameParam = new SqlParameter("@PhoneNumber", phoneNumber);
            SqlParameter[] parameters = { productNameParam };
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, parameters);
            return ds;
        }
        public static bool addEmployee(string fullName, string phoneNumber, string address, string email, string isWorking)
        {
            if (fullName == "" || phoneNumber == "" || address == "" || email == "" || isWorking == "")
                return false;

            try
            {
                String str = "AddEmployeeProc";
                SqlParameter FullNameParam = new SqlParameter("@FullName", fullName);
                SqlParameter PhoneNumParam = new SqlParameter("@PhoneNumber", phoneNumber);
                SqlParameter AddressParam = new SqlParameter("@Address", address);
                SqlParameter EmailParam = new SqlParameter("@Email", email);
                SqlParameter IsWorkingParam = new SqlParameter("@IsWorking", isWorking);
                SqlParameter[] parameters = { FullNameParam, PhoneNumParam, AddressParam, EmailParam, IsWorkingParam };
                bool commandResult = DBConnection.getInstance().ExecuteNonQuery(str, CommandType.StoredProcedure, parameters);
                return commandResult;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool updateEmployee(string id, string fullName, string phoneNumber, string address, string email, string isWorking, string updateType)
        {
            if (id == null || fullName == "" || phoneNumber == "" || address == "" || email == "")
                return false;

            try
            {
                String str = "UpdateEmployeeProc";
                SqlParameter EmployeeIdParam = new SqlParameter("@EmployeeId", id);
                SqlParameter FullNameParam = new SqlParameter("@FullName", fullName);
                SqlParameter PhoneNumParam = new SqlParameter("@PhoneNumber", phoneNumber);
                SqlParameter AddressParam = new SqlParameter("@Address", address);
                SqlParameter EmailParam = new SqlParameter("@Email", email);
                SqlParameter IsWorkingParam = new SqlParameter("@IsWorking", isWorking);
                SqlParameter UpdateTypeParam = new SqlParameter("@UpdateType", updateType);
                SqlParameter[] parameters = { FullNameParam, PhoneNumParam, AddressParam, EmailParam, IsWorkingParam, UpdateTypeParam};
                bool commandResult = DBConnection.getInstance().ExecuteNonQuery(str, CommandType.StoredProcedure, parameters);
                return commandResult;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
