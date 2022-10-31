using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountTransactionApp.CustomExceptionApp;

namespace AccountTransactionApp.Model
{
    internal class Account
    {
        private int _accNo;
        private string _name;
        private double _balance;
        private readonly int _minBalance = 500;
        private List<Transaction> _transactions;

        public Account(int accNo, string name, double balance)
        {
            _accNo = accNo;
            _name = name;
            _balance = balance;
            _transactions = new List<Transaction>();
        }

        

        public void Deposit(double amount)
        {
            _transactions.Add(new Transaction(DateTime.Now, "Deposit", amount));
            _balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (_balance - amount < _minBalance)
            {
                throw new InsufficientFundException(this,amount);
            }
            else
            {
                _transactions.Add(new Transaction(DateTime.Now, "WithDraw", amount));
                _balance -= amount;
            }

        }

        public List<Transaction> GetTransactions
        {
            get { return _transactions; }
        }

        public int AccNo { get { return _accNo; } }

        public string Name { get { return _name; } }

        public double Balance { get { return _balance; } }
    }
}

