using System;
using CircleEncapsulationApp.Model;

namespace CircleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle ce = new Circle();
            ce.SetRadius(10);
            ce.SetBorderStyle("DOUBLE");
            Console.WriteLine("Radius is {0}\n BorderStyle is {1}\n Area is {2}\n Peimeter is {3}",ce.GetRadius(),ce.GetBorderStyle(),ce.CalculateArea(),ce.CalculatePerimeter());
        }
    }
}
