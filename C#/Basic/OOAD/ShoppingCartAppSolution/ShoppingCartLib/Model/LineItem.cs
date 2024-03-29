﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    public class LineItem
    {
        private int _id;
        private int _quantity;
        private Product _product;

        public LineItem(int id, int quantity, Product product)
        {
            _id = id;
            _quantity = quantity;
            _product = product;
        }

        public int Id { get { return _id; } }
        public int Quantity { get { return _quantity; } }
        public Product Product { get { return _product; } }    

        public double CalculateItemPrice()
        {
            double itemPrice = _product.CalculateFinalPrice() * _quantity;
            return itemPrice;
        }
    }
}
