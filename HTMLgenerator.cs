using OrdersSystem.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem
{
    public class HTMLgenerator
    {
        private ReportGenerator reportGenerator { get; set; }
        public HTMLgenerator(ReportGenerator reportGenerator)
        {
            this.reportGenerator = reportGenerator;
        }
        public string GenerateHtmlReportOrders()
        {
            string html = "<table cellpadding='5' style='border:1px solid black; font-size:12pt'>";
            html += "<tr>";
            html += "<th style='background-color: LightGray; border:1px solid black'>Order Number</th>";
            html += "<th style='background-color: LightGray; border:1px solid black'>Order status</th>";
            html += "<th style='background-color: LightGray; border:1px solid black'>Customer</th>";
            html += "<th style='background-color: LightGray; border:1px solid black'>Customer ID</th>";
            html += "<th style='background-color: LightGray; border:1px solid black'>Product</th>";
            html += "</tr>";

            var result = reportGenerator.GenerateNewOrdersByCustomers();
            foreach (var item in result)
            {
                html += "<tr>";
                html += "<td style ='background-color: LightBlue;width:150px;border:1px solid black'>" + item.OrderNumber + "</td>";
                html += "<td style ='background-color: LightBlue;width:150px;border:1px solid black'>" + item.OrderStatus + "</td>";
                html += "<td style ='background-color: LightBlue;width:150px;border:1px solid black'>" + item.FullName + "</td>";
                html += "<td style ='background-color: LightBlue;width:150px;border:1px solid black'>" + ""+ "</td>";
                html += "<td style ='background-color: LightBlue;width:150px;border:1px solid black'>" + "" + "</td>";
                html += "</tr>";
            }
          
            var result2 = reportGenerator.GenerateCustomersByBoughtProductsOver100();
            foreach (var item in result2)
            {
                html += "<tr>";
                html += "<td style ='background-color: #FFB6C1;width:150px;border:1px solid black'>" + item.OrderNumber + "</td>";
                html += "<td style ='background-color: #FFB6C1;width:150px;border:1px solid black'>" + "" + "</td>";
                html += "<td style ='background-color: #FFB6C1;width:150px;border:1px solid black'>" + ""+ "</td>";
                html += "<td style ='background-color: #FFB6C1;width:150px;border:1px solid black'>" + item.CustomerID + "</td>";
                html += "<td style ='background-color: #FFB6C1;width:150px;border:1px solid black'>" + item.ProductName + "</td>";
                html += "</tr>";
            }
            html += "</table>";

            File.WriteAllText(@"C:\Users\sibai\Desktop\mokslai\Visual studio\OrdersSystem\DataFiles\ReportOutput.html", html);
            Console.WriteLine("File created");
            Console.ReadLine();
            return html;
        }
    }
}
