using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApp.Product
{
    internal class BMW : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("BMW starts");
        }

        public void Stop()
        {
            Console.WriteLine("BMW Stops");
        }
    }
}
