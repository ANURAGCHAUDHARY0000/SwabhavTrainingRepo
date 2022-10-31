using System;

namespace ParamsKeyword
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine(Program.add(10, 20, 30, 40, 50));
            Console.ReadKey();
        }
        public static int add(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum = sum + num;
            }
            return sum;
        }
    }
}
