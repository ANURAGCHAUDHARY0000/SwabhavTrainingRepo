using System;
using RectangleApp.Model;
namespace RectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle re = new Rectangle();
            re.width = 10;
            re.height = 20;
            re.color = "black";
            Console.WriteLine(re.width);
            Console.WriteLine(re.height);
            Console.WriteLine(re.color);
            Console.WriteLine(re.CalculateArea());

            Rectangle purple = new Rectangle();
            purple.width = 20;
            purple.height = 40;
            purple.color = "purple";
            Console.WriteLine(purple.width);
            Console.WriteLine(purple.height);
            Console.WriteLine(purple.color);
            Console.WriteLine(purple.CalculateArea());

        }
    }
}
