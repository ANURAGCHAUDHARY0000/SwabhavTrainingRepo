using System;

namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            object obj1 = n;//implicit conversion from value type to refernce type -boxing
            //obj2 = obj1 + obj1;// When a value is boxed the object type variable cannot be used in any mathmatical opr.
            //double d = (double)obj1; casting of box value is not permitted.run time
            int m = (int)obj1;//explicit conversion from ref type to value type - unboxing
            Console.WriteLine(obj1);
            Console.WriteLine(m);
        }
    }
}
