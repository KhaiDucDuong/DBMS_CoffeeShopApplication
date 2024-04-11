using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_WinForm.C_.Classes
{
    public class Account
    {
        private String accountId;
        private String employeeId;
        private String username;
        private String password;
        private String role;
        private String createdAt;
        private String updatedAt;
        private Boolean isDeleted;

        public Account(string accountId, string employeeId, string username, string password, string role, String createdAt, String updatedAt, bool isDeleted)
        {
            this.accountId = accountId;
            this.employeeId = employeeId;
            this.username = username;
            this.password = password;
            this.role = role;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
            this.isDeleted = isDeleted;
        }

        public string AccountId { get => accountId; set => accountId = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public String CreatedAt { get => createdAt; set => createdAt = value; }
        public String UpdatedAt { get => updatedAt; set => updatedAt = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
    }
}
