// To refer current class constructor
using System;

namespace ThisKeyword3
{
    class A
    {
        public A() : this(10)
        {

            Console.WriteLine("A-Con");
        }
        public A(int i)
        {
            Console.WriteLine("int param con - A");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
        }
    }
}
