using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPViolationApp.HighLevel;
using DIPViolationApp.LowLevel;

namespace DIPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator(LogType.FILE);
            Console.WriteLine(calc.Calculate(100,10));
            Console.WriteLine(calc.Calculate(100, 0));

        }
    }
}
