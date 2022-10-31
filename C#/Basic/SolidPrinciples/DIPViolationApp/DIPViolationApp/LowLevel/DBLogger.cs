using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LowLevel
{
    internal class DBLogger
    {
        public void Write(string error)
        {
            Console.WriteLine("Error logged in DB: " + error);
        }
    }
}
