using System;
using PlayerApp.Model;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //Player sachin = new Player(1, "Sachin Tendulkar", 50);
            //Player virat = new Player(2, "Virat Kohli");
            //Player elder = sachin.WhoIsElder(virat);
            //Console.WriteLine();
            //PrintDetails(elder);
            CaseStudy2();


            CaseStudy3();
        }
        public static void CaseStudy1()
        {

            Player sachin = new Player(1, "Sachin Tendulkar", 50);
            PrintDetails(sachin);
            Console.WriteLine();
            Player virat = new Player(2, "Virat Kohli");
            PrintDetails(virat);
            Console.WriteLine();
            Player elder = sachin.WhoIsElder(virat);
            PrintDetails(elder);

        }

        public static void CaseStudy2()
        {
            Player p1 = new Player();
            Console.WriteLine(p1.InstanceCount);
            Player p2 = new Player();
            Console.WriteLine(p1.InstanceCount);
            Player p3 = new Player();
            Console.WriteLine(p1.InstanceCount);

        }

        public static void CaseStudy3()
        {
            Console.WriteLine(Player.HeadCount);
            Console.WriteLine(Player.HeadCount);
            Console.WriteLine(Player.HeadCount);
        }

        public static void PrintDetails(Player player)
        {
            Console.WriteLine("Id: " + player.Id);
            Console.WriteLine("Name: " + player.Name);
            Console.WriteLine("Age :" + player.Age);
            Console.WriteLine(player.GetHashCode());
        }
    }
}
