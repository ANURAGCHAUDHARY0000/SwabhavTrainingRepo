using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp.Model
{
    internal class LineItem
    {
        private int _quantity;
        private double _unitPrice;
        private string _description;

        public LineItem(int quantity, double unitPrice, string description)
        {
            _quantity = quantity;
            _unitPrice = unitPrice;
            _description = description;
        }

        public int Quantity { get { return _quantity; } }
        public double UnitPrice { get { return _unitPrice; } }

        public string Description { get { return _description; } }

        public double CalculateItemPrice()
        {
            return _quantity * _unitPrice;
        }

        public override string ToString()
        {
            return $"Quantity " + Quantity + "\nUnit price of Product is " + UnitPrice +
           "\nProduct Description " + Description + "\nTotal Price Of Product is " + CalculateItemPrice();
        }
    }
}
