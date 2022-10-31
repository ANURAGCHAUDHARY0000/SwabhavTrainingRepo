using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    internal class Program
    {
        //with magic number
        //double PotentialEnergy(double mass, double height)
        //{
        //    return mass * height * 9.81;
        //}
        //without magic number
        const double GRAVITATIONAL_CONSTANT = 9.81;
        public static double PotentialEnergy(double mass, double height)
        {
            return mass * height * GRAVITATIONAL_CONSTANT;
        }
        static void Main(string[] args)
        {
            Console.WriteLine( Program.PotentialEnergy(31, 10));

        }
    }
}
