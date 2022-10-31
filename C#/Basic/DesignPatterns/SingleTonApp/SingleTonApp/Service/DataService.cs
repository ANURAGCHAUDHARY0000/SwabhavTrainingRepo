using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonApp.Service
{
    internal class DataService
    {
        private static DataService _bucket = null;
        private DataService()
        {
            Console.WriteLine("Service Created");
        }

        public void DoProcessing()
        {
            Console.WriteLine("Processing Data By : " + this.GetHashCode());
        }

        public static DataService GetInstance()
        {
            if (_bucket == null)
            {
                    return _bucket = new DataService();
            }
            return _bucket;
        }
    }
}
