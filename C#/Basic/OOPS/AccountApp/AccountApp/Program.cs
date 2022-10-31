using System;
using AccountApp;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             CaseStudy1();
           // CaseStudy2();
        }

        private static void CaseStudy1()
        {
            Account acc1 = new Account(101, "Krishna");
            PrintDetails(acc1);
            acc1.Deposit(100);
            PrintDetails(acc1);
            acc1.Withdrawl(200);
            PrintDetails(acc1);
        }

        private static void CaseStudy2()
        {
            Account acc2 = new Account(102, "Anurag", 1000);
              PrintDetails(acc2);
              acc2.Deposit(100);
              PrintDetails(acc2);
              acc2.Withdrawl(601);
              PrintDetails(acc2);
        }

        private static void PrintDetails(Account acc)
        {
            Console.WriteLine("Name of the Account Holder: " + acc.Name);
            Console.WriteLine("Account no is:" + acc.AccountNumber);
            Console.WriteLine("Account Balance is:" + acc.Balance);

        }
    }
}