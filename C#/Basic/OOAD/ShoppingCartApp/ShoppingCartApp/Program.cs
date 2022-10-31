using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartApp.Model;
using System.IO;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   CaseStudy1();
            //   CaseStudy2();
            //   CaseStudy3();
            //   CaseStudy4();
            //   CaseStudy5();
            //   CaseStudy6();
            //    CaseStudy7();
            CaseStudy8();

        }


        private static void CaseStudy1()
        {
            Product product = new Product(12, "DairyMilk", 100, 10);
            Console.WriteLine($"Product Id : {product.Id}\nProduct Name :" +
            $" {product.Name}\nProduct Price : {product.Price}\nProduct Discount :" +
            $" {product.Discount}%");

        }

        private static void CaseStudy2()
        {
            Product product2 = new Product(1, "DairyMilk", 100, 10);
            Console.WriteLine($"Product Final Price : {product2.CalculateFinalPrice()}");
        }

        private static void CaseStudy3()
        {
            Product product = new Product(11, "Nextar", 50, 10);
            LineItem lineItem1 = new LineItem(1, 10, product);
            Console.WriteLine($"LineItem Id : {lineItem1.Id}\nItem Quantity :" +
            $" {lineItem1.Quantity}\nProduct Id : {product.Id}\nProduct Name :" +
            $" {product.Name}\nProduct Price : {product.Price}\nProduct Discount :" +
            $" {product.Discount}%");

        }

        private static void CaseStudy4()
        {
            Product product = new Product(11, "Nextar", 50, 10);
            LineItem lineItem1 = new LineItem(1, 10, product);
            Console.WriteLine($"Product Final Price : {lineItem1.CalculateItemPrice()}");
        }

        private static void CaseStudy5()
        {
            Product product4 = new Product(12, "DairyMilk", 100, 10);
            LineItem lineItem1 = new LineItem(1, 10, product4);
            Order order = new Order(5, DateTime.Now);
            Console.WriteLine($"LineItem Id : {lineItem1.Id}\nItem Quantity :" +
            $" {lineItem1.Quantity}\nProduct Id : {product4.Id}\nProduct Name :" +
            $" {product4.Name}\nProduct Price : {product4.Price}\nProduct Discount :" +
            $" {product4.Discount}%\nOrder Id : {order.Id}\nOrder DateTime : {order.Date}");
        }


        private static void CaseStudy6()
        {
            Product product4 = new Product(12, "DairyMilk", 100, 10);
            Product product5 = new Product(494, "Noodles", 500, 5);
            LineItem lineItem1 = new LineItem(1, 10, product4);
            LineItem lineItem2 = new LineItem(2, 10, product5);
            Order order = new Order(5, DateTime.Now);
            order.AddItem(lineItem1);
            order.AddItem(lineItem2);
            Console.WriteLine($"CheckOutPrice : {order.CheckOutPrice()}");

        }

        private static void CaseStudy7()
        {
            Customer ram = new Customer(1234, "Ram");
            Console.WriteLine($"Customer Id : {ram.Id}\nCustomer Name : {ram.Name}");
        }

        private static void CaseStudy8()
        {
            Product product4 = new Product(12, "DairyMilk", 100, 10);
            Product product5 = new Product(494, "Noodles", 50, 5);
            LineItem lineItem1 = new LineItem(1, 10, product4);
            LineItem lineItem2 = new LineItem(2, 20, product5);
            Order order = new Order(5, DateTime.Now);
            order.AddItem(lineItem1);
            order.AddItem(lineItem2);
            Customer ram = new Customer(1234, "Ram");
            ram.AddOrder(order);
            PrintCustomerOrderDetails(ram);
            GenerateHtmlFile(ram);

        }

        public static void PrintCustomerOrderDetails(Customer customer)
        {

            int count = 0;
            Console.WriteLine($"Customer Id : {customer.Id}\nCustomer Name : {customer.Name}\n");
            foreach (Order order in customer.GetOrders())
            {
                Console.WriteLine("Order List...");
                Console.WriteLine("Id: " + order.Id);
                Console.WriteLine("Order Date: " + order.Date);
                foreach (var item in order.Items) {
                    Console.WriteLine("Line Item Details ");
                    Console.WriteLine($"Line Item :  {++count} Quantity :  {item.Quantity}");
                    Console.WriteLine("Item Id: " + item.Id);
                    Console.WriteLine("ItemPrice is: " + item.CalculateItemPrice());
                    Console.WriteLine("Product Details....");
                    Console.WriteLine("Product id: " + item.Product.Id);
                    Console.WriteLine("Product Name: " + item.Product.Name);
                    Console.WriteLine("Product Cost: " + item.Product.Price);
                    Console.WriteLine("Product Discount: " + item.Product.Discount + "%");
                    Console.WriteLine("Product Price After Discount: " + item.Product.CalculateFinalPrice());
                    Console.WriteLine("-------------------------------------");
                }

               Console.WriteLine("Checkout Price : " + order.CheckOutPrice());
            }

        }


        public static void GenerateHtmlFile(Customer customer)
        {
            String str = "<body><p>Customer Id: " + customer.Id + "</p><p>Customer Name: " + customer.Name + "</p>";
            str += "<table border='1'>";
            foreach (Order order in customer.GetOrders())
            {
                str += "<p> Order Id: " + order.Id + "</p><p> Date: " + order.Date + "</p>";
                str += "<tr> <td>LineItem Quantity </td> <td>LineItemId</td> " +
                  "<td>Item Price</td> <td>Product Id</td> <td>Product Name </td>" +
                  "<td>Product Cost </td> <td>Product Discount </td>" +
                  "<td>Product Price After Discount </td></tr>";
                foreach (var item in order.Items)
                {
                    str += "<tr><td> " + item.Quantity + "</td><td>  " + item.Id + "</td><td>" + item.CalculateItemPrice() + "</td><td>" + item.Product.Id + "</td>" +
                      "<td>" + item.Product.Name + "</td> <td>" + item.Product.Price + "</td> <td>" + item.Product.Discount + "</td>" +
                      "<td>" + item.Product.CalculateFinalPrice() + "</td></tr>";

                }
                str += "<tr><td>Total Price: </td><td>" + order.CheckOutPrice() + "</td></tr>";

            }
            str += "</table></body>";

         //   Console.WriteLine(str);
            string path = @"D:\Swabhavtechlab\C#\Basic\OOAD\ShoppingCartApp\ShoppingCartApp\write.html";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fs))
                {
                    streamWriter.Write(str);
                }
            }
        }
    }
}