using System;

namespace CopyConstructor
{
    internal class Program
    {
        string _name;
        int _age;
        public Program(string name, int age)    
        {
            _name = name;
            _age = age;
        }
        //Declaring Copy Constructor
        public Program(Program p1)
        {
            _name = p1._name;
            _age = p1._age;
        }
        public void GetData()
        {
            Console.WriteLine("Name is : {0}", _name);
            Console.WriteLine("Age is : {0}", _age);
        }
        static void Main(string[] args)
        {
            Program program1 = new Program("Krishna", 23);
            program1.GetData();
            Program program2 = new Program(program1);
            program2.GetData();
            Console.ReadKey();

        }
    }
}



