// See https://aka.ms/new-console-template for more information
using OrdersSystem;
using OrdersSystem.Repositories;

CustomersRepository customersRepository = new CustomersRepository();
OrdersRepository ordersRepository = new OrdersRepository();
ProductsRepository productsRepository = new ProductsRepository();

ReportGenerator reportGenerator = new ReportGenerator(customersRepository, ordersRepository, productsRepository);
/*var result = reportGenerator.GenerateNewOrdersByCustomers();
foreach (var item in result)
{
    Console.WriteLine(item.OrderNumber);
    Console.WriteLine(item.FullName);
    Console.WriteLine(item.OrderStatus);
    
}*/

var result2 = reportGenerator.GenerateCustomersByBoughtProducts();
foreach (var item in result2)
{
    Console.WriteLine(item.OrderNumber);
    Console.WriteLine(item.FullName);
    Console.WriteLine(item.ProductName);

}

bool working = true;

while (working)
{
    Console.WriteLine("Pasirinkite ataskaita: [1]Neapmokėti užsakymai [2]Klientų ataskaita [3]Išeiti");
    int input = int.Parse(Console.ReadLine());

    switch(input)
    {
        case 1:
            {
                var result = reportGenerator.GenerateNewOrdersByCustomers();
                foreach (var item in result)
                {
                    Console.WriteLine(item.OrderNumber);
                    Console.WriteLine(item.FullName);
                    Console.WriteLine(item.OrderStatus);
                }
                break;
            }
        case 2:
            {
                var result1 = reportGenerator.GenerateCustomersByBoughtProducts();
                foreach (var item in result1)
                {
                    Console.WriteLine(item.OrderNumber);
                    Console.WriteLine(item.FullName);
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
    }
}