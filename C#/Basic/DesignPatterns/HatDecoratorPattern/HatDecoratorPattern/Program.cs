using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HatDecoratorPattern.Model;

namespace HatDecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHat hat = new RibbonedHat(new GoldenHat(new StandardHat()));
            Console.WriteLine("Hat Name: " + hat.GetName());
            Console.WriteLine("Hat Price: " + hat.GetPrice());
            Console.WriteLine("Hat Description: " + hat.GetDescription());

        }
    }
}
