using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorPattern.Model
{
    internal class RibbonedHat : HatDecorator
    {
        IHat hat;

        public RibbonedHat(IHat hat) : base(hat)
        {
            this.hat = hat;
        }

        public override double GetPrice()
        {
            return hat.GetPrice() + 2000;
        }

        public override string GetName()
        {
            return hat.GetName() + "Ribboned Hat";
        }

        public override string GetDescription()
        {
            return hat.GetDescription() + " This is Ribbon Hat";
        }
    }
}
