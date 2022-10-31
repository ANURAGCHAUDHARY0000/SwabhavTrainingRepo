using System;

namespace StringImmutableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "krishna";
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.WriteLine(name.GetHashCode());
            name += "Swabhav";
            Console.WriteLine(name);
            Console.WriteLine(name.GetHashCode());
            name += "Mumbai";
            Console.WriteLine(name);
            Console.WriteLine(name.GetHashCode());

            string s1 = "welcome";
            String s2 = "welcome";
            Console.WriteLine(s1 == s2);//true
            Console.WriteLine(s1.Equals(s2));//true


            String name1 = "Rame";
            Console.WriteLine(name1.ToUpper().GetHashCode());
            Console.WriteLine(name1.GetHashCode());
        }



    }
}
