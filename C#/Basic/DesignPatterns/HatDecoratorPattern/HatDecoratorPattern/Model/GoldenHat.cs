using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorPattern.Model
{
    internal class GoldenHat : HatDecorator
    {
       IHat hat = null;
        public GoldenHat(IHat hat) : base(hat)
        {
            this.hat = hat;
        }

        public override double GetPrice()
        {
            return hat.GetPrice() + 1000;
        }

        public override string GetName()
        {
            return hat.GetName() + "Golden Hat";
        }

        public override string GetDescription()
        {
            return hat.GetDescription() + " This is Golden Hat";
        }
    }
}
