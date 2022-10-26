using Newtonsoft.Json;
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
            /*orders.Add(new Orders(110, 1, 2001, "New"));
            orders.Add(new Orders(111, 2, 2002, "Canceled"));
            orders.Add(new Orders(112, 3, 2003, "Processing"));
            orders.Add(new Orders(113, 4, 2004, "Finished"));
            orders.Add(new Orders(114, 5, 2005, "Finished"));
            orders.Add(new Orders(115, 6, 2006, "New"));
            orders.Add(new Orders(116, 7, 2007, "Canceled"));*/
            using (StreamReader r = new StreamReader("C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\OrdersSystem\\DataFiles\\OrdersData.json"))
            {
                string json = r.ReadToEnd();
                orders = JsonConvert.DeserializeObject<List<Orders>>(json);
            }

        }

        public List<Orders> Retrieve()
        {
            return orders;
        }
        public Orders Retrieve(int number)
        {
            return orders.SingleOrDefault(x => x.OrderNumber == number);
        }
        public Orders RetrieveCustomer(int cus)
        {
            return orders.SingleOrDefault(x => x.CustomerID == cus);
        }
        public Orders RetrieveProduct(int prod)
        {
            return orders.FirstOrDefault(x => x.ProductID == prod);
        }
    }
}
