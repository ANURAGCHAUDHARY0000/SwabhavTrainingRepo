using System;
using CircleApp.Model;

namespace CircleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cr = new Circle();
            cr.radius = 10;
            cr.color = "black";
            Console.WriteLine(cr.radius);
            Console.WriteLine(cr.color);
            Console.WriteLine(cr.Area());
            Console.WriteLine(cr.Perimeter());
        }
    }
}
