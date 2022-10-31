using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorEventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.OnAdditionOperationComplete += PrintDetails;
            calc.Add(10, 20);
           
            calc.OnSubtractionOperationComplete += PrintDetails;
            calc.Subtract(30, 20);
        }
        public static void PrintDetails(int a, int b, int c)
        {
            Console.WriteLine("First Val : {0}\nSecond Val : {1}\nResult : {2}\n",  a, b, c);
        }
    }
}
