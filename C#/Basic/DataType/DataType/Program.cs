using System;

namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = 'G';
            int i = 89;
            short s = 56;
            long l = 4564;
            uint ui = 95;
            ushort us = 76;
            ulong ul = 7624;
            double d = 9.35;
            float f = 3.7330645f;
            decimal dec = 89.5m;

            Console.WriteLine("char: " + c);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);
        }
    }
}
