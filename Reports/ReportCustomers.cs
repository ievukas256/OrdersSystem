﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem.Reports
{
    public class ReportCustomers
    {
        public int OrderNumber { get; set; }
        public string ProductName { get; set; }
        public int CustomerID { get; set; }


        public ReportCustomers(int orderNumber, string productName, int customerID)
        {
            OrderNumber = orderNumber;
            ProductName = productName;
            CustomerID = customerID;
        }

        public ReportCustomers()
        {
        }
    }
}
