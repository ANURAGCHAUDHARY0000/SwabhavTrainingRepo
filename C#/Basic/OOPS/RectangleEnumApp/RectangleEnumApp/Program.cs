using System;
using RectangleEnumApp.Model;

namespace RectangleEnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.WriteLine();
            CaseStudy2();
            Console.WriteLine();
            CaseStudy3();
            Console.WriteLine();
            CaseStudy4();
        }

        public static void CaseStudy1()
        {
            Rectangle rectangle = new Rectangle(30,40,BorderStyleOptions.Dotted);
            PrintDetails(rectangle);
        }

        public static void CaseStudy2()
        {
            Rectangle rectangle1 = new Rectangle(50, 60);
            PrintDetails(rectangle1);
        }

        public static void CaseStudy3()
        {
            Rectangle rectangle2 = new Rectangle(60, 70);
            PrintDetails(rectangle2);
            Console.WriteLine();
            rectangle2.BorderStyle = BorderStyleOptions.Double;
            PrintDetails(rectangle2);
        }

        public static void CaseStudy4()
        {
            Rectangle[] many = {new Rectangle(60,80),new Rectangle(10,20,BorderStyleOptions.Dotted),
                               new Rectangle (15,25),new Rectangle(5,10,BorderStyleOptions.Double)};
            PrintDetails(many);
        }

        public static void PrintDetails(Rectangle[] rec)
        {

            foreach (Rectangle rec2 in rec)
            {
                PrintDetails( rec2);
                Console.WriteLine();
            }
        }

        public static void PrintDetails(Rectangle rectangles)
        {
            Console.WriteLine("Width "+rectangles.Width);
            Console.WriteLine("Height " + rectangles.Height);
            Console.WriteLine("BorderStyle " + rectangles.BorderStyle);
            Console.WriteLine("Area " + rectangles.CalculateArea());

        }


    }
}
