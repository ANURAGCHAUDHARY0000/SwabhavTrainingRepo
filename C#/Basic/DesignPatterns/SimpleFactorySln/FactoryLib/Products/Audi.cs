using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLib.Factory
{
    internal class Audi : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Audi starts");
        }

        public void Stop()
        {
            Console.WriteLine("Audi Stops");
        }
    }
}
