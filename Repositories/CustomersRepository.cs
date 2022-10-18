using OrdersSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem.Repositories
{
    public class CustomersRepository
    {
        private List<Customers> customers { get; set; } = new List<Customers>();
        public CustomersRepository()
        {
            customers.Add(new Customers("Algis Padalgis", "Kaunas", 1));
            customers.Add(new Customers("Algimantas Padalgietis", "Kaunas", 2));
            customers.Add(new Customers("Ona Sudargiene", "Vilnius", 3));
            customers.Add(new Customers("Petras Jonaitis", "Jurbarkas", 4));
            customers.Add(new Customers("UAB Saudirga", "Kaunas", 5));
            customers.Add(new Customers("MB Brolija", "Vilnius", 6));
            customers.Add(new Customers("Justina Marinyte", "Druskininkai", 7));
        }

        public List<Customers> Retrieve()
        {
            return customers;
        }
        public Customers Retrieve(int customerId)
        {
            return customers.SingleOrDefault(x => x.CustomerId == customerId);
        }
    }
}
