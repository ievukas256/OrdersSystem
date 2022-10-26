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
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string OrderStatus { get; set; }
       
        public Orders(int orderNumber, int customerId,int productId, string orderStatus)
        {
            OrderNumber = orderNumber;
            CustomerID = customerId;
            ProductID = productId;
            OrderStatus = orderStatus;
            
        }
    }
}
