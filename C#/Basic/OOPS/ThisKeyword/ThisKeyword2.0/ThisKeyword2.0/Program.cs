//This keyword is used to refer current class method.
using System;
namespace ThisKeyword2
{
    class A
    {
        public void m1()
        {
            Console.WriteLine("m1-A");
            m2();
            this.m2();
        }
        public void m2()
        {
            Console.WriteLine("m2-A");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.m1();
        }
    }
}


