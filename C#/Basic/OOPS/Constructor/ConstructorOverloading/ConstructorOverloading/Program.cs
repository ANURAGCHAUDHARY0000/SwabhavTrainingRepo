using System;
namespace ConstructorOverloading
{
    internal class Program
    {
        int x, y;
        float f;
        string s;
        public Program(int a , float b)
        {
            x = a;
            f = b;
        }
        public Program(int c, string d)
        {
            y = c;
            s = d;
        }
        public void Add()
        {
            Console.WriteLine(x+f);
        }
        public void Add1()
        {
            Console.WriteLine(y + s);
        }
        static void Main(string[] args)
        {
            Program program = new Program(10,13.0f);
            program.Add();

            Program program1 = new Program(10, "Ram");
            program1.Add1();


        }
    }
}
