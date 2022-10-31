using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogDoorAppV1._0.Model;
using DogDoorAppV1._0.Service;
using System.Threading;

namespace DogDoorAppV1._0
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            // CaseStudy1();
             CaseStudy2();
        }

        public static void CaseStudy1()
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside...");
            remote.pressButton();
            Console.WriteLine("\nFido has gone outside...");

            Console.WriteLine("\nFidos all done...");

            Console.WriteLine("\nFidos back inside...");
        }

        public static void CaseStudy2()
        {
             DogDoorSimulator.DogDoorTest(2000);
            //DogDoor door = new DogDoor();
            //Remote remote = new Remote(door);
            //Console.WriteLine();
            //remote.pressButton();
            //Console.WriteLine("\n Fido's gone outside ");
            //try
            //{
            //    Thread.Sleep(10000);
            //}
            //catch (ThreadInterruptedException)
            //{
            //    Console.WriteLine("...but Fido stuck outside ");
            //    Console.WriteLine("\n Fido's start barking.....");
            //    Console.WriteLine(".... so gina grabs the remote control.");
            //    remote.pressButton();
            //    Console.WriteLine("\n fido's back inside");
            //}

        }
    }
}

