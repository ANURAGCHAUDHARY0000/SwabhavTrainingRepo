using System;

namespace CustomExceptionApp.Model
{
   
    internal class Account
    {
        private int _accountNumber;
        private String _name;
        private double _balance;
        public Account(int accountnumber, string name, double balance)
        {
            this._accountNumber = accountnumber;
            this._name = name;
            this._balance = balance;
        }

        public Account(int accountnumber, string name):this(accountnumber, name, 500)
        {
            //this._accountNumber = accountnumber;
            //this._name = name;
            //this._balance = 500;
        }
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }
        public String Name
        {
            get
            {
                return _name;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }


        public void Deposit(double amount)
        {
            this._balance = this._balance + amount;
        }

        public void Withdrawl(double amount)
        {
            if (this._balance - amount >= 500)
            {
                // Console.WriteLine("your balance is " +this._balance+ "You can't withdraw ");
                _balance -= amount;
            }
           else
                 throw new InsufficientFundsException(this);
                
        }
       
    }
}
