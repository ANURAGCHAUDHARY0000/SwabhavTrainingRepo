using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorPattern.Model
{
    internal class StandardHat : IHat
    {
       
        public string GetName()
        {
            return "Standard Hat";
        }

        public double GetPrice()
        {
            return 450;
        }

        public string GetDescription()
        {
            return "This is a standard hat";
        }

    }
}
