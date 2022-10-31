using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private int _discount;

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double Price { get { return _price; } }
        public int Discount { get { return _discount; } }

        public Product(int id, string name, double price, int discount)
        {
            _id = id;
            _name = name;
            _price = price;
            _discount = discount;
        }

        public double CalculateFinalPrice()
        {
            double finalPrice = _price - _price * _discount * 0.01;
            return finalPrice;
        }
    }
}
