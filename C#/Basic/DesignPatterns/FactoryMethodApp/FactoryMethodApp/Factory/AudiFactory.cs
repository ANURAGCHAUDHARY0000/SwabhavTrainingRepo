using FactoryMethodApp.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApp.Factory
{
    internal class AudiFactory : IAutoMobileFactory
    {
        private static AudiFactory _instance = null;
        public IAutomobile Make()
        {
            return  new Audi();
        }
        public static AudiFactory GetInstance()
        {

            if (_instance == null)
            {
                _instance = new AudiFactory();
            }
            return _instance;
        }
    }
}
