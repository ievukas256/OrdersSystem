using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem.Classes
{
    public class Orders
    {
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public string OrderStatus { get; set; }
       

        public Orders(int orderNumber, int customerId, string orderStatus)
        {
            OrderNumber = orderNumber;
            CustomerId = customerId;
            OrderStatus = orderStatus;
            
        }
    }
}
