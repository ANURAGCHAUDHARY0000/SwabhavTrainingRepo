using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLib.Factory
{
    internal class Tesla : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla starts");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla Stops");
        }
    }
}
