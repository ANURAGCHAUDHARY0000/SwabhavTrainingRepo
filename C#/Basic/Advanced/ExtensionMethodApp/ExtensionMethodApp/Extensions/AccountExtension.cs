using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodApp.Model;

namespace ExtensionMethodApp.Extensions
{
    static class AccountExtension
    {
        //this method belongs to account class
        public static void PrintDetails(this Account acc)
        {
            Console.WriteLine("Name of the Account Holder: " + acc.Name);
            Console.WriteLine("Account no is:" + acc.AccountNumber);
            Console.WriteLine("Account Balance is:" + acc.Balance);

        }

    }
}
