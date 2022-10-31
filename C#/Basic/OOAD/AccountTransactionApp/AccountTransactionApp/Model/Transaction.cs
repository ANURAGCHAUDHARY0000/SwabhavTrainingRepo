using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactionApp.Model
{
    internal class Transaction
    {
        private DateTime _time;
        private string _type;
        private double _amount;

        public Transaction(DateTime time, string type, double amount)
        {
            _time = time;
            _type = type;
            _amount = amount;
        }

        public DateTime Time { get { return _time; } }

        public string Type { get { return _type; } }

        public double Amount { get { return _amount; } }


        public override String ToString()
        {
            String result = "";
            result = result + "DateTime: " + Time + "\t";
            result = result + "Type: " + Type + "\t";
            result = result + "Amount: " + Amount + "\t";

            return result;
        }

    }
}
