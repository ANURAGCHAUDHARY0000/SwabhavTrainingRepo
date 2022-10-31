using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AsyncProgrammingApproach
{
    internal class TimePrinter
    {
        public void Print()
        {
            DateTime startTime = DateTime.UtcNow;
            TimeSpan future = TimeSpan.FromMinutes(.16);  //next 10 seconds

            while (DateTime.UtcNow - startTime < future)
            {
                Debug.WriteLine("delay :" + DateTime.Now.ToString("hh:mm:ss"));
            }
            Debug.WriteLine("delay over");
        }

        public Task<int> PrintAsync()
        {
            return Task.Run(() => {
                Print();
                return 10;
            });
        }

    }
}
