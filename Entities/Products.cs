using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem.Classes
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }


        public Products(int productId, string productName, double productPrice, int productQuantity)
        {
            ProductID = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
        }
        public Products(int productId, string productName)
        {
            ProductID = productId;
            ProductName = productName;
        }

        public Products()
        {
        }

        public Products(Products newProduct)
        {
        }
    }
}
