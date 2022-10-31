using System;

namespace CallByValueApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 10;
            UpdateScoreToZero(score);
            Console.WriteLine(score);

            int[] a = { 1, 2, 3 };
            UpdateScore(a);
            foreach (int i in a)
             Console.WriteLine(i);
        }

        public static void UpdateScoreToZero(int x)
        {
            x = 0;

        }

        public static void UpdateScore(int[] x)
        {
          for(int i = 0; i < x.Length; i++)
            {
                x[i] = 0;
                Console.WriteLine(x[i] + " ");
            }
        }
    }
}
