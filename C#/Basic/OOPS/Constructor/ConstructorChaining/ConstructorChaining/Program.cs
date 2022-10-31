using System;
namespace ConstructorChaining
{
    internal class Program
    {
        int _a, _b; float _c;
        public Program()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
        public Program(int a, int b) : this()
        {
            Console.WriteLine("2nd Constructor");
            _a = a; _b = b;
        }
        public Program(int a, int b, float c) : this(a, b)
        {
            Console.WriteLine("3rd Constructor");
            _c = c;
        }

        public float GetAdd()
        {
            return _a + _b + _c;
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            Program a = new Program(10,20,30.3f);
            Console.WriteLine(a.GetAdd());
        }
    }
}
