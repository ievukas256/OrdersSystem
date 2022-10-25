using OrdersSystem;
using OrdersSystem.Classes;
using OrdersSystem.Reports;
using OrdersSystem.Repositories;
using System.Diagnostics;
using System.Xml.Linq;

CustomersRepository customersRepository = new CustomersRepository();
OrdersRepository ordersRepository = new OrdersRepository();
ProductsRepository productsRepository = new ProductsRepository();

ReportGenerator reportGenerator = new ReportGenerator(customersRepository, ordersRepository, productsRepository);

bool working = true;

while (working)
{
	Console.WriteLine("[1]Neapmokėti užsakymai [2]Klientų ataskaita [3]Išeiti \n[4]Prideti produkta [5]Pasalinti produkta [6]Produktu sarasas");
	int input = int.Parse(Console.ReadLine());

	switch(input)
	{
		case 1:
			{
				var result = reportGenerator.GenerateNewOrdersByCustomers();
				foreach (var item in result)
				{
					Console.Write("Uzsakymo numeris:");
					Console.WriteLine(item.OrderNumber);
					Console.Write("Uzsakymo statusas:");
					Console.WriteLine(item.OrderStatus);
					Console.Write("Klientas:");
					Console.WriteLine(item.FullName);
				}
				break;
			}
		case 2:
			{
				var result1 = reportGenerator.GenerateCustomersByBoughtProductsOver100();
				foreach (var item in result1)
				{
					Console.Write("Uzsakymo numeris:");
					Console.WriteLine(item.OrderNumber);
					Console.Write("Kliento numeris:");
					Console.WriteLine(item.CustomerID);
					Console.Write("Produkto pavadinimas:");
					Console.WriteLine(item.ProductName);
				}
				break;
			}
		case 3:
			{
				Console.WriteLine("Viso gero!");
				working = false;
				break;
			}
		case 4:
			{
				productsRepository.AddProduct();
				break;
			}
		case 5:
			{
				productsRepository.DeleteProduct();
				break;
			}
		case 6:
			{
				productsRepository.GetAllProducts();
				break;
			}
		default:
			{
				Console.WriteLine("Tokio meniu punkto nera");
				break;
			}
	}
}

/*JSONgenerator jsonGenerator = new JSONgenerator(reportGenerator);
var jsonResult = jsonGenerator.GenerateJsonWithReports();*/

HTMLgenerator htmlGenerator = new HTMLgenerator(reportGenerator);
var htmlResult = htmlGenerator.GenerateHtmlReportOrders();