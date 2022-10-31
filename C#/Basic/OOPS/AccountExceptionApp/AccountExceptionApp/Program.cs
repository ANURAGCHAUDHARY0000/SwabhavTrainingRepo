using System;

namespace AccountExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Anurag");
            try
            {
                acc1.Withdrawl(2000);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ResetColor();
            Console.WriteLine("End of main");

        }

    }
}

