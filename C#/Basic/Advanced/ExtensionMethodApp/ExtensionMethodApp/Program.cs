using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodApp.Extensions;
using ExtensionMethodApp.Model;


// we can'nt apply inheritance on sealed class.
// so we can'nt add any method in sealed class if we want add then we just need to
//use extension method
namespace ExtensionMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //all are the extension method define in System.Linq package
            //args.OrderBy(x => x);
            //args.Take(5);
            //   CaseStudy1();
            CaseStudy2();
           
        }

        public static void CaseStudy1()
        {
            string name = "Krishna";
            Console.WriteLine(name.Foo());

            string text = "Hello World";
            Console.WriteLine(text.ToSnakeCase());
        }

        public static void CaseStudy2()
        {
            Account account = new Account(100, "krishna ", 3400);
            account.PrintDetails();
           
        }
    }
}
