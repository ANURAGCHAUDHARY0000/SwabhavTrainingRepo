using System;
using AccountTransactionApp.Model;
using System.Collections.Generic;
using AccountTransactionApp.CustomExceptionApp;

namespace AccountTransactionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new Account(101, "Krishna", 1000);
            acc1.Deposit(500);
            PrintDetails(acc1);
            acc1.Deposit(500);
            PrintDetails(acc1);
            try
            {
                acc1.WithDraw(100);
                PrintDetails(acc1);
                acc1.WithDraw(1900);
            }catch(InsufficientFundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void PrintDetails(Account account)
        {
            Console.WriteLine("Account Number : "+account.AccNo);
            Console.WriteLine("Account Name : " + account.Name);
            Console.WriteLine("Account Balance :"+account.Balance);
           
            foreach (var transaction in account.GetTransactions)
            {
                Console.WriteLine("Transaction Details :"+transaction.ToString());
                Console.WriteLine("----------------------------------");
                //Console.WriteLine("Transaction Time :"+transaction.Time);
                //Console.WriteLine("Type :" + transaction.Type);
                //Console.WriteLine("Amount :" + transaction.Amount);
                //Console.WriteLine("---------------------------");
            }
        }
       
    }
}
