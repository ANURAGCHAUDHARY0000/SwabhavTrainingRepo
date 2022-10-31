using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarInspectionDecoratorApp.Model;

namespace CarInspectionDecoratorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new OilChange(new TyreRotation(new CarInspection()));
            Console.WriteLine(service.GetCost());
            Console.WriteLine("--------------------");
            Console.WriteLine(service.GetDetails());
        }
    }
}
