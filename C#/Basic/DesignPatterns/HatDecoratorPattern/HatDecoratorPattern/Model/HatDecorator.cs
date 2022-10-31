using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorPattern.Model
{
    abstract class HatDecorator : IHat
    {
        IHat _hat;
        public HatDecorator(IHat hat)
        {
            this._hat = hat;
        }

        public virtual string GetDescription()
        {
            return _hat.GetDescription();
        }

        public virtual string GetName()
        {
            return _hat.GetName();  
        }

        public virtual double GetPrice()
        {
            return _hat.GetPrice();   
        }
    }
}
