using System;

namespace MovableInterfaceApp.Model
{
    internal class Bike : Vehicle
    {
        public Bike(string name) : base (name) { }

        public override void Move()
        {
            Console.WriteLine("Bike is moving  " + _name);
        }


    }
}
