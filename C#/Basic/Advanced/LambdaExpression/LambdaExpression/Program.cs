using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    // Create a delegate
    public delegate string GreetingsDelegate(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            // An anonymous method is a method which doesn’t contain any name 
            //it has only body
            // Anonymous method with one parameter
            //GreetingsDelegate obj = delegate (string name)
            //{
            //    return "Hello" + name + "a very good morning!";
            //};
            //Lamda Expression it's the shorthand notation of anonymous method
            GreetingsDelegate obj  = (name) =>
            {
                return "Hello" + name + "a very good morning!";
            };

            string str = obj.Invoke(" Ram ");
            Console.WriteLine(str);
        }
    }
}
