using System;


namespace AccountPolymorphismApp.Model
{
    internal class CurrentAccount : Account
    {
        private int creditLimit = -5000;
        public CurrentAccount(int accountNumber, string name, double balance)  : base(accountNumber,name,balance)
        {

        }

        public CurrentAccount(int accountNumber,string name)   :base(accountNumber, name, 0)     // we can use here this instead of base
        {

        }

        public override void Withdraw(double amount)
        {
            if(this._balance - amount >= creditLimit)
                this._balance -= amount;
            else
                Console.WriteLine("Your credit limit is over!");
        }
    }
}
