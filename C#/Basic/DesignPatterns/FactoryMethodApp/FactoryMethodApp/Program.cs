using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodApp.Factory;
using FactoryMethodApp.Product;

namespace FactoryMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        public static void CaseStudy1()
        {
            IAutoMobileFactory factory;
            factory =  new BMWFactory();
            // factory = new AudiFactory();
            // factory = new TeslaFactory();
            IAutomobile auto = factory.Make();
            auto.Start();
            auto.Stop();

        }


        public static void CaseStudy2()
        {
            IAutoMobileFactory factory;
           // factory = BMWFactory.GetInstance();
             factory = AudiFactory.GetInstance();
            //factory = TeslaFactory.GetInstance();
            IAutomobile auto = factory.Make();
            auto.Start();
            auto.Stop();

        }

    }
}
