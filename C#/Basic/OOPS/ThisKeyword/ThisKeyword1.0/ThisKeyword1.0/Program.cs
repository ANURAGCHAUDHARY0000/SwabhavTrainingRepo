//this keyword is used to refer current class variable.
using System;
namespace ThisKeyword1
{
  public class B
    {
       public int i = 10;
       public int j = 20;
       public B(int i, int j)
        {
            Console.WriteLine(i+" "+j);
            Console.WriteLine(this.i+" "+this.j);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B(30, 40);
        }
    }
}
