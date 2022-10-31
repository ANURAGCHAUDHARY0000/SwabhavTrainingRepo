using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Model;

namespace OCPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Ram", 2000, 2, new DiwaliFestivalPolicy());
            var fd2 = new FixedDeposit("Krishna", 10000, 7, new RamzanPolicy());
            Console.WriteLine(fd1.CalculateSimpleInterest());
            Console.WriteLine(fd2.CalculateSimpleInterest());
            Console.WriteLine(fd1);
            Console.WriteLine("-----------------------------");
            Console.WriteLine(fd2);
        }
    }
}
