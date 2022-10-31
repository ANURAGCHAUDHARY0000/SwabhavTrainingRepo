using System;
namespace ParametrisedOrExplicitConstructor
{
    internal class Program
    {
        int x;
        public Program(int i)
        {
            x = i;
            Console.WriteLine("Parametrised Constructor is called : " + i);
        }
        public void Display()
        {
            Console.WriteLine("The value of x is : " + x);
        }
        static void Main(string[] args)
        {
            Program program1 = new Program(10);
            Program program2 = new Program(200);
            program1.Display();
            program2.Display();

        }
    }
}
