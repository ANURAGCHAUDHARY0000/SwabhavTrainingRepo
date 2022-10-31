using FactoryMethodApp.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApp.Factory
{
   
    internal class BMWFactory : IAutoMobileFactory
    {
        private static BMWFactory _instance = null;
        public IAutomobile Make()
        {
           return new BMW();
        }

        public static BMWFactory GetInstance()
        {

            if (_instance == null)
            {
                _instance = new BMWFactory();
            }
            return _instance;
        }
    }
}
