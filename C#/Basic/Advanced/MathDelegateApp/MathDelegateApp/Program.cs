using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegateApp
{
    delegate void DMathOperation(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            DMathOperation m1;
            m1 = Add;
            m1 += Subtract;
            m1 += Modulus;
            m1 += Multiplication;
            m1 += Division;
            m1(5, 3);

            Console.ReadKey();
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition of {0} + {1} is : "   + (a + b),a,b);
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction of  {0} - {1} is : " + (a - b), a, b);
        }

        public static void Modulus(int a, int b)
        {
            Console.WriteLine("Modulus of {0} % {1}  is : " + (a % b),a,b);
        }

        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication of  {0} * {1} is : " + (a * b),a,b);
        }
        public static void Division(int a, int b)
        {
            float result = a / b;

            Console.WriteLine("Division of {0} / {1} is  : " + result,a,b);
        }
    }
}
