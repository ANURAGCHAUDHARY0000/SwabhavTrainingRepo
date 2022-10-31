using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountTransactionApp.Model;

namespace AccountTransactionApp.CustomExceptionApp
{
    internal class InsufficientFundException : Exception
    {
        string _message;

        public InsufficientFundException(Account acc, double withdrawamount)
        {
            _message = $"Insuffucient funds in account {acc.AccNo}!!\n You are trying to withdrow {withdrawamount}\nyou can withdrow {acc.Balance - 500} only \nTransaction Declined!!";
        }
        public override string Message
        {
            get
            {
                return _message;
            }
        }

    }
}
