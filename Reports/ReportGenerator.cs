using OrdersSystem.Classes;
using OrdersSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem.Reports
{
    public class ReportGenerator
    {
        private CustomersRepository CustomersRepository;
        private OrdersRepository OrdersRepository;
        private ProductsRepository ProductsRepository;

        public ReportGenerator(CustomersRepository customersRepository, OrdersRepository ordersRepository, ProductsRepository productsRepository)
        {
            CustomersRepository = customersRepository;
            OrdersRepository = ordersRepository;
            ProductsRepository = productsRepository;
        }

        public List<ReportCustomers> GenerateCustomersByBoughtProducts()
        {
            List<Products> products = ProductsRepository.Retrieve();
            List<Orders> orders = new List<Orders>();
            List<Customers> customers = new List<Customers>();
            List<int> customersProducts = new List<int>();
            List<ReportCustomers> reportCustomers = new List<ReportCustomers>();

            foreach (var product in products)
            {
                var produc = ProductsRepository.Retrieve(product.ProductID);
                var order = OrdersRepository.RetrieveProduct(produc.ProductID);
                var customer = CustomersRepository.Retrieve(order.CustomerID);


                if (product.ProductName == "Stalas")
                {
                    customersProducts.Add(product.ProductID);
                }
            }
            foreach (var id in customersProducts)
            {
                reportCustomers.Add(new ReportCustomers()
                {
                    OrderNumber = OrdersRepository.RetrieveProduct(id).OrderNumber,
                    ProductName = ProductsRepository.Retrieve(id).ProductName,
                    CustomerID = OrdersRepository.RetrieveProduct(id).CustomerID,
                    //FullName = CustomersRepository.Retrieve(id).FullName,
                });
                
            }
            return reportCustomers;
        }

        public List<ReportOrders> GenerateNewOrdersByCustomers()
        {
            List<Orders> orders = OrdersRepository.Retrieve();
            List<Customers> customers = new List<Customers>();
            List<int> orderByCustomer = new List<int>();
            List<ReportOrders> reportOrders = new List<ReportOrders>();

            foreach (var ord in orders)
            {
                var order = OrdersRepository.Retrieve(ord.OrderNumber);
                var customer = CustomersRepository.Retrieve(order.CustomerID);
               
                if (order.OrderStatus == "New")
                {
                    orderByCustomer.Add(ord.CustomerID);
                }
            }
            foreach (var id in orderByCustomer)
            {
                reportOrders.Add(new ReportOrders()
                {
                    OrderNumber = OrdersRepository.RetrieveCustomer(id).OrderNumber,
                    FullName = CustomersRepository.Retrieve(id).FullName,
                    OrderStatus = OrdersRepository.RetrieveCustomer(id).OrderStatus
                });
            }
            return reportOrders;
        }
    }
}
