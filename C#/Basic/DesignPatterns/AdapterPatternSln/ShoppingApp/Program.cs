using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalLib.Model;
using ShoppingApp.Model;

namespace ShoppingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new ShoppingCart();
            shop.AddItem(new Book("Ramayana", 1000));

            Hat hat = new Hat("Ree", "Reebook", 120);

            shop.AddItem(new HatAdapter(hat));

            PrintDetails(shop);
        }

        public static void PrintDetails(ShoppingCart cart)
        {
            foreach(var item in cart.Items)
            {
                Console.WriteLine( item.ItemName());
                Console.WriteLine(item.ItemPrice());
                
            }
        }
    }
}
