using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem.Classes
{
    public class Customers
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }

        public Customers(int customerId, string fullName, string city )
        {
            FullName = fullName;
            City = city;
            CustomerID = customerId;
        }
    }
}
