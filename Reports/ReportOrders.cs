using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem.Reports
{
    public class ReportOrders
    {
        public int OrderNumber { get; set; }
        public string FullName { get; set; }
        public string OrderStatus { get; set; }
       

        public ReportOrders(int orderNumber, string fullName, string orderStatus)
        {
            OrderNumber = orderNumber;
            FullName = fullName;
            OrderStatus = orderStatus;
           
        }

        public ReportOrders()
        {
        }
    }
}
