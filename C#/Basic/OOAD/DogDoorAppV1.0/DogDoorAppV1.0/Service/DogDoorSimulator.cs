using System;
using DogDoorAppV1._0.Model;
using System.Timers;

namespace DogDoorAppV1._0.Service
{
    internal class DogDoorSimulator
    {
        public static void DogDoorTest(int dogOutsideTime)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("\nFido barks to go outside ...");
            remote.pressButton();

            Console.WriteLine("\nFido has gone outside for " + dogOutsideTime / 1000 + " seconds ...");
            System.Threading.Thread.Sleep(dogOutsideTime);
            Console.WriteLine("\nFido's all done ...");
           
            Console.WriteLine("\nFido's back inside ...");

            door.Close();
          
        }
    }
    }

