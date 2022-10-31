using System;


namespace AccountPolymorphismApp.Model
{
    internal class SavingAccount : Account
    {
        public SavingAccount(int accountNumber, string name, double balance):base(accountNumber,name,balance)
        {
        }
        // thumb rule
        public SavingAccount(int accountNumber , string name) : this(accountNumber,name,500)
        {

        }

        public override void Withdraw(double amount)  //if we are implementing abstract method then we must have to override
        {
            if (this._balance - amount > 500)
                this._balance = this._balance - amount;

            else
                Console.WriteLine("Your balance is low ");

        }

    }
}
