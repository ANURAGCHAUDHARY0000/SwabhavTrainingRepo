using System;
using ProductApp.Model;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productId = 123;
            product1.productName = "Mobile";
            product1.actualPrice = 12000;
            product1.discountPercentage = 20;
            Console.WriteLine("Product Id is : "+product1.productId);
            Console.WriteLine("Product Name is : "+product1.productName);
            Console.WriteLine("Actual Price of Product is : "+product1.actualPrice);
            Console.WriteLine("Discount Percentage on Product is : "+product1.discountPercentage);
            Console.WriteLine("Price of Product after dicount is : "+product1.CostAfterDiscount());
            Console.WriteLine();
            Product product2 = new Product();
            product2.productId = 121;
            product2.productName = "Tv";
            product2.actualPrice = 11000;
            product2.discountPercentage = 20;
            Console.WriteLine("Product Id is : "+product2.productId);
            Console.WriteLine("Product Name is : "+product2.productName);
            Console.WriteLine("Actual Price of Product is : "+product2.actualPrice);
            Console.WriteLine("Discount Percentage on Product is : "+product2.discountPercentage);
            Console.WriteLine("Price of Product after dicount is : "+product2.CostAfterDiscount());
            Console.ReadKey();     
        }
    }
}
