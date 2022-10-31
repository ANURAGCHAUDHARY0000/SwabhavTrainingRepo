using System;


namespace AccountPolymorphismApp.Model
{
    internal abstract class Account
    {
        private int _accountNumber;
        private string _name;
        protected double _balance;

        public Account(int accno, string name, double balance)
        {
            _accountNumber = accno;
            _name = name;
            _balance = balance;
        }

        public int AccountNumber { get { return _accountNumber; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public abstract void Withdraw(double amount);// if we are using abstract method then we must have to declare class as abstract.
       
            }
}
