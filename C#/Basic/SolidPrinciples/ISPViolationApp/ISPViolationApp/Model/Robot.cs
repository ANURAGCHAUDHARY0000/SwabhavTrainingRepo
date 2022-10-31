using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    internal class Robot : IWorker
    {
        public void StartWork()
        {
            Console.WriteLine("Robot started working");
        }

        public  void StopWork()
        {
            Console.WriteLine("Robot stopped working");
        }
        public void StartEat()
        {
            throw new Exception("Robot can't eat");
        }

        public void StopEat()
        {
            throw new Exception("Robot can't eat");
        }

        
    }
}
