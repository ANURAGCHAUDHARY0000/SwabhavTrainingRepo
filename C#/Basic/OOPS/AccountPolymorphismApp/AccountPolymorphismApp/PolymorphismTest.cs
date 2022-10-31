using System;
using AccountPolymorphismApp.Model;

namespace AccountPolymorphismApp
{
    internal class PolymorphismTest
    {
        static void Main(string[] args)
        {
             CaseStudy1();
             CaseStudy2();
             Console.WriteLine("Printing Details of Current Account");
             Console.WriteLine();
             CaseStudy3();
             CaseStudy4();

        }
        public static void CaseStudy1()
        {
            SavingAccount s1 = new SavingAccount(101,"Anurag",5000);
            PrintDetails(s1);
            s1.Deposit(500);
            PrintDetails(s1);
            s1.Withdraw(500);
            PrintDetails(s1);
            s1.Withdraw(6999);
            PrintDetails(s1);

        }

        public static void CaseStudy2()
        {
            SavingAccount s2 = new SavingAccount(102, "Anu");
            PrintDetails(s2);
            s2.Withdraw(200);
            PrintDetails(s2);
            s2.Deposit(500);
            PrintDetails(s2);
            s2.Withdraw(200);
            PrintDetails (s2);
            
        }

        public static void CaseStudy3()
        {
            CurrentAccount c1 = new CurrentAccount(102, "Anu",4000);
            PrintDetails(c1);
            c1.Deposit(200);
            PrintDetails(c1);
            c1.Withdraw(200);
            PrintDetails(c1);
            c1.Withdraw(9000);
            PrintDetails(c1);

        }

        public static void CaseStudy4()
        {
            CurrentAccount c2 = new CurrentAccount(102, "Anu");
            PrintDetails(c2);
            c2.Deposit(1000);
            PrintDetails (c2);
            c2.Withdraw(500);
            PrintDetails(c2);
            c2.Withdraw(6000);
            PrintDetails(c2);
        }

        public static void PrintDetails(Account acc)
        {
            Console.WriteLine("Account Number is :" + acc.AccountNumber);
            Console.WriteLine("Account Holder Name is :" + acc.Name);
            Console.WriteLine("Balance is :" + acc.Balance);
            Console.WriteLine();
        }
    }
}
