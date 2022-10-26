using Newtonsoft.Json;
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
			/*customers.Add(new Customers(1,"Algis Padalgis", "Kaunas"));
			customers.Add(new Customers(2,"Algimantas Padalgietis", "Kaunas"));
			customers.Add(new Customers(3,"Ona Sudargiene", "Vilnius"));
			customers.Add(new Customers(4,"Petras Jonaitis", "Jurbarkas"));
			customers.Add(new Customers(5,"UAB Saudirga", "Kaunas"));
			customers.Add(new Customers(6,"MB Brolija", "Vilnius"));
			customers.Add(new Customers(7,"Justina Marinyte", "Druskininkai"));*/

			using (StreamReader r = new StreamReader("C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\OrdersSystem\\DataFiles\\CustomersData.json"))
			{
				string json = r.ReadToEnd();
				customers = JsonConvert.DeserializeObject<List<Customers>>(json);
			}
		}

		public List<Customers> Retrieve()
		{
			return customers;
		}
		public Customers Retrieve(int customerId)
		{
			return customers.FirstOrDefault(x => x.CustomerID == customerId);
		}
	   
	}
}
