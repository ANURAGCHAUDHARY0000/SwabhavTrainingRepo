using System;
using PublisherLib.Common;
using System.Collections.Generic;

namespace PublisherLib.Model
{
    public class Account
    {
        private int _accountNumber;
        private String _name;
        private double _balance;
        private  List<INotificationBalanceChange> _notifier = new List<INotificationBalanceChange>(); 
        public Account(int accountnumber, string name, double balance)
        {
            this._accountNumber = accountnumber;
            this._name = name;
            this._balance = balance;
           
        }

        public Account(int accountnumber, string name):this(accountnumber, name, 500)
        {
            
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
            NotifySubscriber();
        }

        public void Withdrawl(double amount)
        {
            if (this._balance - amount < 500)
            {
                Console.WriteLine("your balance is " +this._balance+ "You can't withdraw ");
            }
            else
            {
                _balance -= amount;
                NotifySubscriber();
            }
        }

        public void AddSubscriber(INotificationBalanceChange notification)
        {
            _notifier.Add(notification);
        }

        public void NotifySubscriber()
        {
            foreach(var notifier in _notifier)
            {
                notifier.Notify(this);
            }
        }
       
    }
}
