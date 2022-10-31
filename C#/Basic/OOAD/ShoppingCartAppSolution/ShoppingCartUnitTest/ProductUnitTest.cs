using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCartLib.Model;


namespace ShoppingCartUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Product_Class_Constructor_Initialise_With4Parameters()
        {
            //Arrange
            int expectedProductid = 1;
            string expectedProductname = "oil";
            double expectedProductprice = 300;
            int expectedProductdiscount = 10;

            //Act
             Product product = new Product(1,"oil",300,10);
           //Assert
            Assert.AreEqual(product.Id,expectedProductid);
            Assert.AreEqual(product.Name,expectedProductname);
            Assert.AreEqual(product.Price,expectedProductprice);
            Assert.AreEqual(product.Discount,expectedProductdiscount);
        }

        [TestMethod]
        public void Test_Product_CLass_CalculateFinalPrice_Method()
        {
           double expectedProductPrice = 128;
            Product product1 = new Product(11, "oil", 160, 20);
            Assert.AreEqual(expectedProductPrice, product1.CalculateFinalPrice());
        }

    }
}
