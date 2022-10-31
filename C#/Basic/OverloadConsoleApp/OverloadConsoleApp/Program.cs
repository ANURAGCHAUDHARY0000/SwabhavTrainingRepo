using System;

namespace OverloadConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = { "Ram", "Shyam", "Sita" };
            PrintDetails(userNames);
            int[] userMarks = { 1, 2, 3 };
            PrintDetails(userMarks);
            char[] symbols = { '#', 'a', '@' };
            PrintDetails(symbols);
        }
        private static void PrintDetails(string[] userNames)
        {
            for (int i = 0; i < userNames.Length; i++)
            {
                Console.WriteLine(userNames[i]);
            }
        }

        private static void PrintDetails(int[] userMarks)
        {
            for (int i = 0; i < userMarks.Length; i++)
            {
                Console.WriteLine(userMarks[i]);
            }
        }

        private static void PrintDetails(char[] symbols)
        {
            for (int i = 0; i < symbols.Length; i++)
            {
                Console.WriteLine(symbols[i]);
            }
        }
    }
}
