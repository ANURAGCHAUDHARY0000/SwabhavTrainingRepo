using System;
using AccountEventApp.Publisher;

namespace AccountEventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "abc", 1000);
            acc1.OnBalanceChanged += SendSmsNotification;
            acc1.OnBalanceChanged += SendEmailNotification;
            acc1.Deposit(100);
        }

        public static void SendEmailNotification(Account account)
        {
            Console.WriteLine("\nSending Mail...");
            Console.WriteLine("Mail send to Account Number {0} Account " +
                "Balance is {1} ,Account Name {2}", account.AccNo, account.AccBalance,account.Name);
        }

        public static void SendSmsNotification(Account account)
        {
            Console.WriteLine("\nSending SMS...");
            Console.WriteLine("SMS send to Account Number {0} Account " +
            "Balance is {1},Account Name {2}", account.AccNo, account.AccBalance, account.Name);
        }


    }
}
