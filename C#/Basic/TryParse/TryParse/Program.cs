using System;
namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "20";
            int x;
            bool b = int.TryParse(s,out x);
          
          Console.WriteLine(b);
          Console.WriteLine(x);
        }
    }
}
