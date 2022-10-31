using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.LowLevel
{
    internal class FileLogger : ILogger
    {
        public void Write(string error)
        {
            Console.WriteLine("Error logged in file: " + error);
        }
    }
}
