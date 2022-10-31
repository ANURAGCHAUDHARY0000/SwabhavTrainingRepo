using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPViolationApp.Model;

namespace ISPViolationApp
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
			AtTheCafeteria(robo);
		}

		public static void AtTheWorkStation(IWorker worker)
		{
            Console.WriteLine("At the work station");
			worker.StartWork();
			worker.StopWork();
		}

		public static void AtTheCafeteria(IWorker worker)
		{
            Console.WriteLine("At the cafeteria");
			worker.StartEat();
			worker.StopEat();
		}
	}
}
