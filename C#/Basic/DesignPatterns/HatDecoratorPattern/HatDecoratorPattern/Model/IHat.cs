using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorPattern.Model
{
    public interface IHat
    {
         String GetName();

         double GetPrice();

        String GetDescription();
    }
}
