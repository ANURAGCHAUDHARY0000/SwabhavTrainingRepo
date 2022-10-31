using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // declaration of delegate
    delegate void DMessage(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an object of delegate
            DMessage obj;
            obj = SayHello;
            obj("ram");

            obj = SayGoodBye;
            obj("Shiva");

            MessageWizard(SayHello);

            //MultiCaseDelegate

            DMessage multi;
            multi = SayHello;
            multi += SayGoodBye;
            multi += SayGoodBye;

            //fire

            multi("CHAMP");


        }

        //make function same signature of delegate

        public static void SayHello(string name)
        {
            Console.WriteLine("hello says  :" + name);
        }

        public static void SayGoodBye(string name)
        {
            Console.WriteLine("Good Bye Says  :"+ name);
        }

        public static void Foo() { }

        public static void MessageWizard(DMessage msg) {
            Console.WriteLine("inside message wizard");
            msg("Aurionpro");
        }
    }
}
