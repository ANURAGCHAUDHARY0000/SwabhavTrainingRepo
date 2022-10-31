using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPSolutionApp.Model;

namespace ISPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var robo = new Robot();

            AtTheWorkStation(manager);
            AtTheWorkStation(robo);

            AtTheCafeteria(manager);

        }
        public static void AtTheWorkStation(IWorkable worker)
        {
            Console.WriteLine("At the work station");
            worker.StartWork();
            worker.StopWork();
        }

        public static void AtTheCafeteria(IEatable worker)
        {
            Console.WriteLine("At the cafeteria");
            worker.StartEat();
            worker.StopEat();
        }
    }
}
