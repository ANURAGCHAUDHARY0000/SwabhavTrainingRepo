using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISPViolationApp.Model
{
    internal class Manager : IWorker
    {
       public void StartWork()
        {
            Console.WriteLine("manager started working");
        }

       public void StopWork()
        {
            Console.WriteLine("manager stoped working");
        }

        public void StartEat()
        {
            Console.WriteLine("Manager started eating");

        }

       public void StopEat()
        {
            Console.WriteLine("Manager stopped eating");
        }
    }
}
