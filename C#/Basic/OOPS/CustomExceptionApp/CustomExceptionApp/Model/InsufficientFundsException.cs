using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionApp.Model
{
    internal class InsufficientFundsException : Exception 
    {

        Account acc;

        public InsufficientFundsException(Account acc)
        {
            this.acc = acc;
        }
        public override string Message
        {
            get
            {
                return $"Account Holder Name : " + acc.Name +
            "\nAccount Number  :" + acc.AccountNumber +
            "\ntried to withdraw money but he has only :" + acc.Balance + "\nInsufficient Balance";
            }

        }

        public InsufficientFundsException(string message) : base(message)
        {

        }
    }
}
