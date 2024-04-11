using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_WinForm.C_.Classes
{
    public class Product
    {
        private String productId;
        private String productName;
        private String productSize;
        private String productPrice;
        private String createdAt;
        private String updatedAt;
        private Boolean isDeleted;

        public Product(string productId, string productName, string productSize, string productPrice, string createdAt, string updatedAt, bool isDeleted)
        {
            this.productId = productId;
            this.productName = productName;
            this.productSize = productSize;
            this.productPrice = productPrice;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
            this.isDeleted = isDeleted;
        }

        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductSize { get => productSize; set => productSize = value; }
        public string ProductPrice { get => productPrice; set => productPrice = value; }
        public string CreatedAt { get => createdAt; set => createdAt = value; }
        public string UpdatedAt { get => updatedAt; set => updatedAt = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
    }
}
