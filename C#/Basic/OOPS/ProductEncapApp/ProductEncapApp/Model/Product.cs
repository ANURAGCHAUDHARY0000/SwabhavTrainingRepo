using System;
namespace ProductEncapApp.Model
{
    internal class Product
    {
        private string _productName;
        private int _productId;
        private float _productPrice;
        private float _discountPercentage;

        public void SetName(string productName)
        {
            _productName = productName;
        }
        public void SetId(int productId)
        {
            _productId = productId;
        }
        public void SetPrice(float productPrice)
        {
            _productPrice = productPrice;
        }
        public void SetDiscountPercenatge(float discountPercentage)
        {
            _discountPercentage = discountPercentage;
        }
        public float CostAfterDiscount()
        {
            float priceAfterdiscount = _productPrice - (_productPrice * (_discountPercentage / 100));
            return priceAfterdiscount;
        }

        public string GetProductName()
        {
            return _productName;
        }

        public int GetProductId()
        {
            return _productId;
        }
        public float GetProductPrice()
        {
            return _productPrice;
        }
        public float GetDiscountPercentage()
        {
            return _discountPercentage;
        }
    }
}
