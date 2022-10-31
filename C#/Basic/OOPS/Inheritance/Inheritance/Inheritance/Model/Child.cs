using System;
 
namespace Inheritance.Model
{
    internal class Child : Parent
    {
        public void m2()
        {
            Console.WriteLine("Child method is called");
            Console.WriteLine(i); //we can access parent class variable and method in child class directly 
             m1();            //without using any parent class refernce variable and without creating superclass object. 
        }
      

    }
}
