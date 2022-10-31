using System;

namespace ProductApp.Model
{
    internal class Product
    {
        public int productId;
        public string productName;
        public int actualPrice;
        public double discountPercentage;

        public double CostAfterDiscount()
        {
            double priceAfterdiscount = actualPrice - (actualPrice * (discountPercentage / 100));
            return priceAfterdiscount; 
        }
    }
}
