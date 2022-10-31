using System;

namespace MovableInterfaceApp.Model
{
    internal class Car : Vehicle
    {

        public Car(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine("Car is moving  " + _name);
        }
    }
}
