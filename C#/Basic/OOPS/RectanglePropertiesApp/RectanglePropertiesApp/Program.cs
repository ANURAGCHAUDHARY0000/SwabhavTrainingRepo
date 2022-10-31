using System;
using RectanglePropertiesApp.Model;

namespace RectanglePropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            small.Width = 10;
            small.Height = 20;
            small.CalculatePerimeter();
            small.CalculateArea();
         //   PrintDetails(small, "small rectangle");

            Rectangle big = new Rectangle();
            big.Width = 40;
            big.Height = 50;
            big.CalculatePerimeter();
            big.CalculateArea();
           // PrintDetails(big, "big rectangle");

            Rectangle medium = new Rectangle();
            medium.Width = 25;
            medium.Height = 35;
            medium.CalculatePerimeter();
            medium.CalculateArea();
         //   PrintDetails(medium, "medium rectangle");

            Rectangle extralarge = new Rectangle();
            extralarge.Width = 35;
            extralarge.Height = 45;
            extralarge.CalculatePerimeter();
            extralarge.CalculateArea();
        //    PrintDetails(extralarge, "extralarge rectangle");

            Rectangle extrasmall = new Rectangle();
            extrasmall.Width = 55;
            extrasmall.Height = 65;
            extrasmall.CalculatePerimeter();
            extrasmall.CalculateArea();
            //   PrintDetails(extrasmall, "extrasmall rectangle");

            //PrintDetails(new Rectangle(), "anonymous");
            //Console.WriteLine("area of anonymous object  : " + new Rectangle().CalculateArea());
            //PrintDetails(null, null);
            //Console.WriteLine("end of program");

            Rectangle[] manyrectangle = new Rectangle[5];
            manyrectangle[0] = small;
            manyrectangle[1] = big;
            manyrectangle[2] = medium;
            manyrectangle[3] = extralarge;
            manyrectangle[4] = extrasmall;


            //foreach (Rectangle many in manyrectangle)
            //{
            //    PrintDetails(many);
            //}
            PrintDetails(manyrectangle);

        }
        public static void PrintDetails(Rectangle [] many)
        {
            Console.WriteLine("Printing details of different rectangle");
            //foreach (Rectangle rect in many)
            //{
            //    Console.WriteLine("Width is :{0}\nHeight is :{1}\nArea is :{2}\nPerimeter is :{3}",
            //    rect.Width, rect.Height, rect.CalculateArea(), rect.CalculatePerimeter());
            //    Console.WriteLine();
            //}
            foreach (Rectangle rect in many)
            {
                  PrintDetails(rect, rect.ToString());
              
            }
            //for(int i = 0; i < many.Length; i++)
            //{
            //    Console.WriteLine(many[i],i.ToString());
            //}
        }
        
        public static void PrintDetails(Rectangle re, string description)
        {
            Console.WriteLine("Printing details of " + description);
            Console.WriteLine("Width is: {0}\nHeight is: {1}\nArea is: {2}\nPerimeter is: {3}", re.Width, re.Height, re.CalculateArea(), re.CalculatePerimeter());
        }
    }
}

