// To return Current Class Object
using System;

namespace ThisKeyword4
{
    class A
    {
        public A GetRef1()
        {
            A a = new A();
            return a;
        }

        public A GetRef2() 
        {
            return this;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(a.GetRef1().GetHashCode());
            Console.WriteLine(a.GetRef1().GetHashCode());
            Console.WriteLine( );
            Console.WriteLine(a.GetRef2().GetHashCode());
            Console.WriteLine(a.GetRef2().GetHashCode());
        }
    }
}
