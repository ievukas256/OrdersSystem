using OrdersSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem.Repositories
{
    public class ProductsRepository
    {
        private List<Products> products { get; set; } = new List<Products>();
        public ProductsRepository()
        {
            products.Add(new Products(2001, "Stalas", 105.50, 2));
            products.Add(new Products(2002, "Biuro kede", 55, 5));
            products.Add(new Products(2003, "Komoda", 150.60, 10));
            products.Add(new Products(2004, "Spintele", 25, 23));
            products.Add(new Products(2005, "Popierius", 5.50, 99));
            products.Add(new Products(2006, "Spausdintuvas", 250, 7));
            products.Add(new Products(2007, "Monitorius", 450, 0));
        }

        public List<Products> Retrieve()
        {
            return products;
        }
        public Products Retrieve(int productId)
        {
            return products.SingleOrDefault(x => x.ProductID == productId);
        }
    }
}
