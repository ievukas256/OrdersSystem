using OrdersSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem.Repositories
{
    public class OrdersRepository
    {
        private List<Orders> orders { get; set; } = new List<Orders>();
        public OrdersRepository()
        {
            orders.Add(new Orders(110, 1, "New"));
            orders.Add(new Orders(111, 2, "New"));
            orders.Add(new Orders(112, 3, "New"));
            orders.Add(new Orders(113, 4, "New"));
            orders.Add(new Orders(114, 5, "New"));
            orders.Add(new Orders(115, 6, "New"));
            orders.Add(new Orders(116, 7, "New"));
        }

        public List<Orders> Retrieve()
        {
            return orders;
        }
        public Orders Retrieve(int orderId)
        {
            return orders.SingleOrDefault(x => x.OrderNumber == orderId);
        }
    }
}
