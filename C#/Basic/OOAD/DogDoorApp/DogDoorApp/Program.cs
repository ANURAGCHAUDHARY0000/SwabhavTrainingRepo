using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogDoorApp.Model;
using DogDoorApp.Service;

namespace DogDoorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
			DogDoor door = new DogDoor();
			Remote remote = new Remote(door);

            Console.WriteLine("Fido barks for going outside...");
			remote.pressButton();

            Console.WriteLine ("\nFido has gone outside...");
			remote.pressButton();

            Console.WriteLine ("\nFido's all done...");
			remote.pressButton();

            Console.WriteLine("\nFido's back inside...");
			remote.pressButton();

		}
    }
}
