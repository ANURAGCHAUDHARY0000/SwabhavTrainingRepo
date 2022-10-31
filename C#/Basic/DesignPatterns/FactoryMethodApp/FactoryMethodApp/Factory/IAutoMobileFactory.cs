using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodApp.Product;

namespace FactoryMethodApp.Factory
{
    public interface IAutoMobileFactory
    {
        IAutomobile Make();
    }
}
