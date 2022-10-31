using System;
using ManBoyInterfaceApp.Model;


namespace ManBoyInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man x = new Man();
            Boy y = new Boy();

            AtTheParty(x);
            AtTheParty(y);

         //   AtTheMovies(x);
            AtTheMovies(y);
        }

        public static void AtTheParty(IMannerable obj)
        {
            Console.WriteLine("At the Party");
            obj.Wish();
            obj.Depart();
        }

        public static void AtTheMovies(IEmotionable obj)
        {
            Console.WriteLine("At The Movies");
            obj.Cry();
            obj.Laugh();
        }
    }
}
