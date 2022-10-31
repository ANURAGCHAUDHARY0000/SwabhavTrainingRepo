using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = args;
            //  CaseStudy1(args);
            CaseStudy2(args);
        }

        public static void CaseStudy1(string[] args)
        {
            IEnumerable<string> names = args;
            names.ToList().ForEach(Display);

           // Anonymous function
            names.ToList().ForEach(delegate (string n)
            {
                Console.WriteLine("Inside Anonymous Function " + n.ToUpper());
            });
         //   Delegates
            names.ToList()
                 .ForEach((n) => Console.WriteLine("Inside Lamda function " + n.ToUpper()));   
        }

        public static void CaseStudy2(string[] args)
        {
            IEnumerable<string> names = args;

            //Query Display all name which contains letter A
            IEnumerable<string> namesWithA = names.Where(DoesNameHaveA); //Defered,delay,lazy,execution

            // Query to Display Long Name

            IEnumerable<string> namesWithA_LongNames = namesWithA.Where(IsLongName); //Defered,delay,lazy,execution

            // Console.WriteLine(namesWithA);

            //Immediate Execute
            foreach (string name in namesWithA)
            {
                Console.WriteLine(name);
            }

            List <string> lstOfLongNamesWithA = namesWithA_LongNames.ToList();
            Console.WriteLine(lstOfLongNamesWithA.Count);
            lstOfLongNamesWithA.ForEach(Display);
        }

        public static void CaseStudy3()
        {

        }
        public static void Display(string name)
        {
            Console.WriteLine("Inside Named Functio");
            Console.WriteLine(name.ToUpper());

        }   

        public static bool DoesNameHaveA(string name)
        {
            Console.WriteLine("Inside Named Function");
            return name.ToUpper().Contains("A");

        }

        public static bool IsLongName(string name)
        {
            return name.Length > 5;
        }
    }
}
