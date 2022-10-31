using System;


namespace InheritanceApp.Model
{
    internal class Boy : Man
    {
        public void Eat()
        {
            Console.WriteLine("Boy eat method");
         }
        public override void Play()
        {
            Console.WriteLine("Boy play method");
        }
    }
}
