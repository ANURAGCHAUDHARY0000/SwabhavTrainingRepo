using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLib.Factory
{
    public class AutoMobileFactory
    {
        private static AutoMobileFactory _instance = null;
        public IAutomobile Make(AutoType msg)
        {
            if (msg == AutoType.BMW)
            {
                return new BMW();
            }
            else if (msg == AutoType.AUDI)
            {
                return new Audi();
            }
            else
            {
                return new Tesla();
            }
        }

        public static AutoMobileFactory GetInstance()
        {

            if (_instance == null)
            {
                _instance = new AutoMobileFactory();
            }
            return _instance;
        }
    }
}
