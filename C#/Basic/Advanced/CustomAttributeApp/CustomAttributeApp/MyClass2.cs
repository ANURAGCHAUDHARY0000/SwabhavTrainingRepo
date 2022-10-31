using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp
{
    internal class MyClass2
    {
        [MyNeedToRefactorAttribute]
        public void F1()
        {
            Console.WriteLine("Inside F1");
        }

        [MyNeedToRefactorAttribute]
        public void F2()
        {
            Console.WriteLine("Inside F2");
        }


        [MyNeedToRefactorAttribute]

        public void F3()
        {
            Console.WriteLine("Inside F3");
        }
    }
}
