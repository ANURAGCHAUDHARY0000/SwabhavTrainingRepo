using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorPattern.Model
{
    internal class PremiumHat : IHat
    {
      
        public string GetName()
        {
            return "Premium Hat";
        }

        public double GetPrice()
        {
            return 900;
        }

        public string GetDescription()
        {
            return "This is a Premium hat";
        }

    }
}
