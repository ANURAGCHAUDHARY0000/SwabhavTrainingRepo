using System;
using Inheritance.Model;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.m1();
            // p.m2(); //whatever the parent has bydefault available to child but vice versa not true.
            Console.WriteLine();
            Child c = new Child(); // by using child refernce we can call both parent and child class method.
            c.m1();
            c.m2();
            Console.WriteLine();
            Parent p1 = new Child(); //  Parent reference can used to hold child object but we can'nt access child specific method.
            p1.m1();
            // p1.m2(); 

           // Child c2 = new Parent();//child refernce can'nt used to hold parent object.
        }
    }
}
