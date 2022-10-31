using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventApp.Publisher
{
    public delegate void DBalanceChangeNotification(Account account);
    public class Account
    {
        public event DBalanceChangeNotification OnBalanceChanged = null;

        private int _id;
        private string _name;
        private double _balance;
        public Account(int id, string name, double balance)
        {
            _id = id;
            _name = name;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            if(OnBalanceChanged != null)
                OnBalanceChanged(this);
        }
        public int AccNo
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double AccBalance
        {
            get
            {
                return _balance;
            }
        }
    }
}
