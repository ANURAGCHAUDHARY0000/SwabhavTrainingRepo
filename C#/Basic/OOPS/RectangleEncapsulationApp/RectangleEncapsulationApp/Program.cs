using System;
using RectangleEncapsulationApp.Model;

namespace RectangleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle re = new Rectangle();
            re.SetWidth(20);
            re.SetHeight(30);
            re.SetColor("green");
            re.SetBorderColor("Yellow");
            Console.WriteLine(" Area is: {0}\n Perimeter is: {1}\n Width is: {2}\n Height is: {3}\n Color is: {4} \n BorderColor is :{5}", 
            re.CalculateArea(), re.CalculatePerimeter(), re.GetWidth(), re.GetHeight(), re.GetColor(), re.GetBorderColor());
            Console.ReadKey();

        }
    }
}
