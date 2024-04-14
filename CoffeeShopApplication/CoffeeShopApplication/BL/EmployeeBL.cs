using CoffeeShopApplication.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static DataSet findEmployeeByPhoneNume(String phoneNum)
        {
            String str = "SELECT * FROM dbo.findCustomerByPhoneNumberFunction(@PhoneNumber)";
            SqlParameter productNameParam = new SqlParameter("@employeeName", phoneNum);
            SqlParameter[] parameters = { productNameParam };
            DataSet ds = DBConnection.getInstance().ExecuteQuery(str, CommandType.Text, parameters);
            return ds;
        }

        public static bool addEmployee(string fullName, string phoneNumber, string address, string email, bool isWorking)
        {
            if (fullName == "" || phoneNumber == "" || address == "" || email == "" || isWorking == false)
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

        public static bool updateEmployee(Guid id, string fullName, string phoneNumber, string address, string email, bool isWorking)
        {
            if (id == null || fullName == "" || phoneNumber == "" || address == "" || email == "" || isWorking == false)
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
                SqlParameter[] parameters = { FullNameParam, PhoneNumParam, AddressParam, EmailParam, IsWorkingParam };
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
