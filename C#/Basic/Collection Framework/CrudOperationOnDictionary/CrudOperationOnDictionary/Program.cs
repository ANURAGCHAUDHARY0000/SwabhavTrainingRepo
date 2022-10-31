using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationOnDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> My_dict1 = new Dictionary<int, string>();

            My_dict1.Add(1, "Krishna");
            My_dict1.Add(2, "Ram");
            My_dict1.Add(3, "Radha");

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0}  {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();


            My_dict1.Remove(1);
            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0}  {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();


            My_dict1[2] = "HareKrishna";
            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0}  {1}",
                          ele1.Key, ele1.Value);
            }

        }


    }
}
