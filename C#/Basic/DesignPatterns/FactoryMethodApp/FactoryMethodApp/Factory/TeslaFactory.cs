using FactoryMethodApp.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApp.Factory
{
    internal class TeslaFactory : IAutoMobileFactory
    {
        private static TeslaFactory _instance = null;
        public IAutomobile Make()
        {
            return new Tesla();
        }

        public static TeslaFactory GetInstance()
        {

            if (_instance == null)
            {
                _instance = new TeslaFactory();
            }
            return _instance;
        }
    }
}
