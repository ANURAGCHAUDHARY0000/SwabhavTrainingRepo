using System;

namespace InheritanceApp.Model
{
    internal class Man
    {
        public void Read()
        {
            Console.WriteLine("Man read method ");
        }
        public virtual void Play()
        {
            Console.WriteLine("Man play method ");
        }
    }
}
