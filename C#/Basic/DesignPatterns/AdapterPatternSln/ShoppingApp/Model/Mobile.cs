using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{
    internal class Mobile : IItem
    {
        private string _name;
        private double _price;

        public Mobile(string name , double price)
        {
            _name = name;
            _price = price;
        }
        public string ItemName()
        {
         
         return _name;
            
        }

        public double ItemPrice()
        {
            return  _price;
        }
    }
}
