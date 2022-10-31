using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScanAnd_FindMethods_WhichNeed_Refactoring(typeof(MyClass2));

            ScanAnd_FindMethods_WhichNeed_Refactoring(typeof(MyClass1));

        }

        public static void ScanAnd_FindMethods_WhichNeed_Refactoring(Type type)
        {
            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                if (Attribute.IsDefined(method, typeof(MyNeedToRefactorAttribute)))
                {
                    Console.WriteLine(method.Name);
                   
                }
            }


        }

       
    }
}
