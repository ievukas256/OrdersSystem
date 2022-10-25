using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OrdersSystem.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace OrdersSystem.Repositories
{
	public class ProductsRepository
	{
		private List<Products> products { get; set; } = new List<Products>();
		public ProductsRepository()
		{
		   /* products.Add(new Products(2001, "Stalas", 105.50, 2));
			products.Add(new Products(2002, "Biuro kede", 55, 5));
			products.Add(new Products(2003, "Komoda", 150.60, 10));
			products.Add(new Products(2004, "Spintele", 25, 23));
			products.Add(new Products(2005, "Popierius", 5.50, 99));
			products.Add(new Products(2006, "Spausdintuvas", 250, 7));
			products.Add(new Products(2007, "Monitorius", 450, 0));*/

			using (StreamReader r = new StreamReader("C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\OrdersSystem\\DataFiles\\ProductsData.json"))
			{
				string json = r.ReadToEnd(); 
				products = JsonConvert.DeserializeObject<List<Products>>(json);
			} 
		}
		public List<Products> Retrieve()
		{
			return products;
		}
		public Products Retrieve(int productId)
		{
			return products.FirstOrDefault(x => x.ProductID == productId);
		}
		public void GetAllProducts()
		{
			foreach(Products item in products)
			{
				Console.WriteLine($"ProductID: {item.ProductID}");
				Console.WriteLine($"ProductName: {item.ProductName}");
				Console.WriteLine($"ProductPrice: {item.ProductPrice}");
				Console.WriteLine($"ProductQuantity: {item.ProductQuantity}");
				Console.WriteLine("------------------");
			}
		}
		public void Save(Products entity)
		{
			products.Add(entity);
		}
		public Products AddProductEntities()
		{
            Console.WriteLine("Iveskite produkto pavadinima:");
            string name = Console.ReadLine();
            Console.WriteLine("Iveskite produkto kaina:");
            double price = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite produkto kieki:");
            int quant = int.Parse(Console.ReadLine());
            int id = products.Max(x => x.ProductID);
            int id2 = id + 1;

            var newProduct = new Products(id2, name, price, quant);
            products.Add(newProduct);
            Console.WriteLine($"Sukurtas naujas produktas: {id2} {name} {price} {quant}");
            return newProduct;
        }
		public void AddProductToFile()
		{
			var newProduct = AddProductEntities();
            string path = @"C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\OrdersSystem\\DataFiles\\ProductsData.json";
			var jsonString = File.ReadAllText(path);
			var list = JsonConvert.DeserializeObject<List<Products>>(jsonString);
			list.Add(newProduct);
			var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
			File.WriteAllText(path, convertedJson);
		}
		public Products EnterProductToDelete()
		{
            Console.WriteLine("Iveskite produkto ID kuri norite pasalinti");
            int productId = int.Parse(Console.ReadLine());

            var item = products.SingleOrDefault(x => x.ProductID == productId);
            products.Remove(item);
            return item;
        }
		public void DeleteProductFromFile()
		{
			var item = EnterProductToDelete();
            string path = @"C:\Users\sibai\Desktop\mokslai\Visual studio\OrdersSystem\DataFiles\ProductsData.json";
            var jsonString = File.ReadAllText(path);
            var list = JsonConvert.DeserializeObject<List<Products>>(jsonString);
			list.RemoveAll(list => list.ProductID == item.ProductID).ToString();
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(path, convertedJson);
			Console.WriteLine("Produktas pasalintas");
		}
	}
}
