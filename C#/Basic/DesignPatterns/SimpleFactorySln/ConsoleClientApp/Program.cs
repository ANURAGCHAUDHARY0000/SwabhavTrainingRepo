using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryLib.Factory;

namespace ConsoleClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  CaseStudy1();
            CaseStudy2();
           
        }

        public static void CaseStudy1()
        {
            AutoMobileFactory factory = new AutoMobileFactory();
            IAutomobile product = factory.Make(AutoType.BMW);
            Console.WriteLine(product.GetType());
            product.Start();
            product.Stop();
        }

        public static void CaseStudy2()
        {
            AutoMobileFactory factory =  AutoMobileFactory.GetInstance();

            IAutomobile product = factory.Make(AutoType.BMW);
            Console.WriteLine(product.GetType());
            product.Start();
            product.Stop();

            IAutomobile product2 =  factory.Make(AutoType.AUDI);
            Console.WriteLine(product2.GetType());
            product2.Start();
            product2.Stop();

        }
    }
}
