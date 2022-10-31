using System;
using MovableInterfaceApp.Model;

namespace MovableInterfaceApp
{
    internal class PolymorphismTest
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike("BMW");
            Car car = new Car("Oddy");
            Truck truck = new Truck("Volvo FH 16");

            Imovable[] movables = new Imovable[] { bike,car,truck };

            StartTheRace(movables);

        }

        public static void StartTheRace(Imovable[] movables)
        {
            Console.WriteLine("Start the race ");
            foreach (Imovable movable in movables)
            {
                movable.Move();
            }
            Console.WriteLine("End the race");
        }
    }
}
