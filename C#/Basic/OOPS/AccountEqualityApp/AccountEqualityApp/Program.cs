using System;

namespace AccountEqualityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  ToStringCaseStudy();
            EqualsCaseStudy();
        }

      
        public static void ToStringCaseStudy()
        {
            Account acc1 = new Account(101, "Krishna", 5000);
            Console.WriteLine("Child --->"+acc1);
            //Console.WriteLine(acc1.ToString().GetHashCode());
            //Console.WriteLine(acc1);
            //onsole.WriteLine(acc1.GetType());
            Console.WriteLine("Child --->"+acc1);
           
        }

        public static void EqualsCaseStudy()
        {
            Account acc1 = new Account(101, "Anurag", 5000);
            Account acc2 = new Account(101, "Anurag", 5000);
            Account acc3 = acc1;
            Console.WriteLine(acc3==acc1);        // Referential Equality  // True  // After Override // true
            Console.WriteLine(acc1==acc2);        // Referential Equality  // False  // After Override // false
            Console.WriteLine(acc1.Equals(acc2)); // Value Equality // False         // After Override //  true
            Console.WriteLine(acc3.Equals(acc1)); // true only if the references are the same.
        }

    }
}
