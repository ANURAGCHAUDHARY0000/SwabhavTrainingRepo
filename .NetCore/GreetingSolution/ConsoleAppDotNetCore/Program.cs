using GreetingStandardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDotNetFrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from dot net core..");
            Greeting greeting = new Greeting();
            Console.WriteLine(greeting.Message);
        }
    }
}
