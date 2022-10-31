using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SRP_SolutionApp.Model
{
    internal class Invoice
    { 
        private int _id;
        private string _title;
        private double _amount;
        private int _discountPercent;
        private float _tax = 18;

        public Invoice(int id, string title, double amount, int discountPercent)
        {
            _id = id;
            _title = title;
            _amount = amount;
            _discountPercent = discountPercent;
        }

        public double CalculateTaxAmount()
        {
            return _amount * _tax / 100;
        }

        public double CalculateDiscountedAmount()
        {
            return _amount * _discountPercent / 100;
        }
        public double CalculateFinalAmount()
        {
             return (_amount - CalculateDiscountedAmount()) + CalculateTaxAmount();
        }
       
        public int Id { get { return _id; } }
        public string Title { get { return _title; } }
        public double Amount { get { return _amount; } }
        public int DiscountPercent { get { return _discountPercent; } }
        public float Tax { get { return _tax; } }

       

    }
}

