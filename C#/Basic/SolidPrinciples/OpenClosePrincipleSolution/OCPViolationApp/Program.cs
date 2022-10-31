using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPViolationApp.Model;

namespace OCPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fixedDeposit = new FixedDeposit("Krishna", 1000, 5, FestivalType.DIWALI);
           // PrintDetails(fixedDeposit);
            Console.WriteLine(fixedDeposit.CalculateSimpleInterest());
            Console.WriteLine(fixedDeposit);
        }

        public static void PrintDetails(FixedDeposit fixes)
        {
            Console.WriteLine("Name " + fixes.Name);
            Console.WriteLine("Principle Amount " + fixes.Principle);
            Console.WriteLine("Duration " + fixes.Duration);
            Console.WriteLine("Festival " + fixes.Festival);
            Console.WriteLine("Rate " + fixes.CalculateRate());
            Console.WriteLine("Simple Interest " + fixes.CalculateSimpleInterest());
        }
    }
}
