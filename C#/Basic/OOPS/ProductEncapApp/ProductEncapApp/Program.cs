using System;
using ProductEncapApp.Model;
namespace ProductEncapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.SetId(1);
            p.SetName("TV");
            p.SetPrice(12000);
            p.SetDiscountPercenatge(20);
            Console.WriteLine("Product Id is : {0}\nProduct Name is : {1}\nProduct Price is : {2}\nDiscount percentage on product is :{3}\nPrice of Product after discount is :{4}",
             p.GetProductId(),p.GetProductName(),p.GetProductPrice(),p.GetDiscountPercentage(),p.CostAfterDiscount());

        }
    }
}
