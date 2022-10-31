using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationOnHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> foods = new HashSet<string>
            {
                "Burger",
                "Chowmein",
                "Idaly"
                
            };
            foods.Add("Rice");
            foods.Add("Rice");   // duplicate records are ignored without throwing any error

            foreach (var food in foods)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine("Remove Operations");

            if (foods.Contains("Rice"))
            {
                foods.Remove("Rice");
            }
            foreach (var food in foods)
            {
                Console.WriteLine(food);
            }

        }
    }
}
