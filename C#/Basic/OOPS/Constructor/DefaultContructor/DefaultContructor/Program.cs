using System;
namespace DefaultContructor
{
    internal class Program
    {
        int i; bool b; string s ;
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.i);
            Console.WriteLine(program.b);
            Console.WriteLine(program.s);
            Console.ReadLine();
        }
    }
}
