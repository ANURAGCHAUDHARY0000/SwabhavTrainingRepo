using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTonApp.Service;
using System.Threading;

namespace SingleTonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            Thread t1 = new Thread(() =>
            {
                var service1 = DataService.GetInstance();
                service1.DoProcessing();
            });

            Thread t2 = new Thread(() =>
            {
                var service2 = DataService.GetInstance();
                service2.DoProcessing();
            });

            Thread t3 = new Thread(() =>
            {
                DataService.GetInstance().DoProcessing();   
            });

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("End Of Program");
            Console.ReadLine();
        }


        public static void CaseStudy1()
        {
            var service1 = DataService.GetInstance();
            var service2 = DataService.GetInstance();

            service1.DoProcessing();
            service2.DoProcessing();

            Console.WriteLine(service1.GetHashCode());
            Console.WriteLine(service2.GetHashCode());

        }
    }
}
