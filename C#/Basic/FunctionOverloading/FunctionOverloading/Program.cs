using System;
namespace FunctionOverloading
{
    internal class Program
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }
            public static void Main(string[] args)
            {
                Program p = new Program();
                Console.WriteLine("Sum of two int numbers is :" + p.Add(1, 2));
                Console.WriteLine("Sum of two float numbers is :" + p.Add(2.3f, 4.5f));
            }
        }
    }

