using System;
using System.Collections.Generic;
using GuitarApp.Model;
using GuitarApp.Service;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.AddGuitar("AB12", 12000, Builder.FENDER, "SN100", GuitarType.ELECTRIC, BackWood.INDIANROSEWOOD, TopWood.COCOBOLD, 10);
            inventory.AddGuitar("CS13", 9000, Builder.MARTIN, "DA102", GuitarType.ELECTRIC, BackWood.MAHOGANY, TopWood.SITKA, 6);
            inventory.AddGuitar("WE56", 11000, Builder.GIBSON, "MA102", GuitarType.ACOUSTIC, BackWood.INDIANROSEWOOD, TopWood.ALDER, 10);
            inventory.AddGuitar("SA12", 16000, Builder.FENDER, "SN100", GuitarType.ELECTRIC, BackWood.INDIANROSEWOOD, TopWood.COCOBOLD, 10);

            PrintDetails(inventory.GetGuitar("AB12"));


            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "SN100", GuitarType.ELECTRIC, BackWood.INDIANROSEWOOD, TopWood.COCOBOLD, 10);
            

            List<Guitar> findingGuitar = inventory.Search(whatErinLikes);

            if (findingGuitar.Count>0)
            {
                Console.WriteLine("Erin,You might like this guitars..");

                foreach (var guitar in findingGuitar)
                {
                    PrintDetails(guitar);
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin,we have nothing for you....");
            }
        }

        public static void PrintDetails(Guitar guitar)
        {
            GuitarSpec spec = guitar.Spec;
            Console.WriteLine("We have this company Guitar : " + spec.Builder +
                                      "\n Serial number is : " + guitar.SerialNumber+
                                      "\n Model number is :" + spec.Model +
                                     "\n Guitar Type is :" + spec.GuitarType +
                                     "\n Guitar BackWood is :" + spec.BackWood +
                                     "\n Guitar Topwood is : " + spec.TopWood +
                                     "\n You can have it for only $" +
                                      guitar.Price + " ----");

            Console.WriteLine("------------------------------");
        }

    }

}


