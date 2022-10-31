using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Model
{
    internal class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man Departing Saying Good Bye...");
        }

        public void Wish()
        {
            Console.WriteLine("Man Wishing Happy Birthday Lord Krishna ");
        }
    }
}
