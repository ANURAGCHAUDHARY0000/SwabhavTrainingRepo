using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    internal class Manager : IWorkableEatable
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
            Console.WriteLine("Manager stopeed eating");
        }
     }
}
