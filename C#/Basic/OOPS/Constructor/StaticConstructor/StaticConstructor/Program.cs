using System;
namespace StaticConstructor
{
    internal class Program
    {
        public static string name;
        public static int age;
        static Program()
        {
            name = "Krishna";
            age = 23;
            Console.WriteLine("Static constructor is invoked");
        }
        public Program()
        {
            Console.WriteLine("Default Contructor is called");
        }
        public static void GetDetails()
        {
            Console.WriteLine("Person name is : {0} ", name);
            Console.WriteLine("Person age is : {0}", age);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Program.GetDetails();

        }
    }
}
