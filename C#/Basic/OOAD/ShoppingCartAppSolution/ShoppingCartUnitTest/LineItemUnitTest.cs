using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCartLib.Model;

namespace ShoppingCartUnitTest
{
    [TestClass]
    public class LineItemUnitTest
    {
        [TestMethod]
        public void Test_LineItem_Constructor()
        {
            //Arrange
            int expectedId = 111;
            int expectedQuantity = 2;
            //Act
            Product product = new Product(11, "oil", 200, 20);
            LineItem line = new LineItem(111, 2, product);
            //Assert
            Assert.AreEqual(expectedId,line.Id);
            Assert.AreEqual(expectedQuantity,line.Quantity);
            Assert.AreEqual(product,line.Product);
        }

        [TestMethod]
        public void Test_Calculate_Line_Item_Price()
        {
            double expectedCalculateitemPrice = 320;
            Product product = new Product(11, "oil", 200, 20);
            LineItem line = new LineItem(111, 2, product);
            Assert.AreEqual(expectedCalculateitemPrice,line.CalculateItemPrice());
        }

      
    }
}
