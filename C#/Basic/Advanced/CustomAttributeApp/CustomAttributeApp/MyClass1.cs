using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp
{
    internal class MyClass1
    {
        [MyNeedToRefactorAttribute]

        public void M1()
        {
            Console.WriteLine("Inside M1");
        }

        public void M2()
        {
            Console.WriteLine("Inside M2");
        }


        [MyNeedToRefactorAttribute]

        public void M3()
        {
            Console.WriteLine("Inside M3");
        }
    }
}
