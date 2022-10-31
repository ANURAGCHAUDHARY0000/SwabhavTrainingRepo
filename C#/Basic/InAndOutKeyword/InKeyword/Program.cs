using System;
namespace InKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            ChangeValue(a);
            Console.WriteLine(a);

            ChangeValue2(out a);
            Console.WriteLine(a);
        }
        static bool ChangeValue(in int x)
        {
            return true;
        }
        static bool ChangeValue2(out int x)
        { 
            x = 20;
            return true;
        }
    }
}
