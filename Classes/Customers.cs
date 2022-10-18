using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem.Classes
{
    public class Customers
    {
        public string FullName { get; set; }
        public string City { get; set; }
        public int CustomerId { get; set; }


        public Customers(string fullName, string city, int customerId)
        {
            FullName = fullName;
            City = city;
            CustomerId = customerId;
        }
    }
}
