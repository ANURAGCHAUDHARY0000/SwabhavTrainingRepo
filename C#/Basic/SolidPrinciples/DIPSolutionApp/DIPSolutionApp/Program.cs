using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolutionApp.HighLevel;
using DIPSolutionApp.LowLevel;

namespace DIPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var calc = new TaxCalculator(new FileLogger());
            Console.WriteLine(calc.CalculateTax(100,10));
            Console.WriteLine(calc.CalculateTax(17, 0));
            Console.WriteLine(calc.CalculateTax(16, 3));
            Console.ReadLine();
        }
    }
}
