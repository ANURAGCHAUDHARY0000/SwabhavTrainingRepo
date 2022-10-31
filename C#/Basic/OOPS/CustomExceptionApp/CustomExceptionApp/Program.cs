using System;
using CustomExceptionApp.Model;

namespace CustomExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  CaseStudy1();
            CaseStudy2();
           
        }
        public static void CaseStudy1()
        {
            Account acc1 = new Account(1, "Anurag", 5000);
            acc1.Withdrawl(4600);
            printDetails(acc1);
        }

        public static void CaseStudy2()
        {
            Account acc2 = new Account(2, "Krishna", 2000);
            try
            {
                acc2.Withdrawl(1700);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine (e.Message);
                Console.WriteLine();
               
            }
          
            printDetails(acc2);
        }
        public static void printDetails(Account account)
        {
            Console.WriteLine("Account No:\t " + account.AccountNumber);
            Console.WriteLine("Name:\t\t " + account.Name);
            Console.WriteLine ("Balance:\t " + account.Balance);
        }
    }
}
