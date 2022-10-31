using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperationOnArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(true);
            Console.WriteLine(al.Capacity);
            al.Add("Krishna"); al.Add(1.34);al.Add("456");al.Add(121);
            Console.WriteLine(al.Capacity);
            foreach(object obj in al)
            Console.Write(obj+" ");
            Console.WriteLine();

            al.Insert(3, "abc");
            foreach (object obj in al)
            Console.Write(obj + " ");
            Console.WriteLine();

            al.Remove("abc");
            foreach (object obj in al)
            Console.Write(obj + " ");
            Console.WriteLine();


        }
    }
}
