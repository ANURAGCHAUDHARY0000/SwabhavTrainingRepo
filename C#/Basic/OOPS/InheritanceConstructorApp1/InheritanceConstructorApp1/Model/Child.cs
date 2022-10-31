using System;


namespace InheritanceConstructorApp1.Model
{
    internal class Child : Parent
    {
        public Child(): base()
        {
            Console.WriteLine("Child is Created");
        }
    }
}
