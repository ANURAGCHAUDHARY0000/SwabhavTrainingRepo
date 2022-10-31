using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCartLib.Model;

namespace ShoppingCartUnitTest
{
    [TestClass]
    public class OrderUnitTest
    {
        [TestMethod]
        public void Test_Order_Class_Constructor()
        {
            //Arrange
            int expectedOrderId = 5;
            DateTime expectedDate = DateTime.Now;
            //Act
            Order order = new Order(5,DateTime.Now);
            //Assert
            Assert.AreEqual(expectedOrderId,order.Id);
            Assert.AreEqual(expectedDate,order.Date);
        }

        [TestMethod]

        public void Test_Item_List()
        {
            Product product = new Product(11, "oil", 200, 20);
            LineItem line = new LineItem(111, 2, product);
            Order order = new Order(123, DateTime.Now);
            order.Items.Add(line);
            int expectedValue = order.Items.Count;
            Assert.AreEqual(expectedValue, order.Count);
        }

        [TestMethod]
        public void Test_AddItem_Method()
        {
            Product product4 = new Product(12, "DairyMilk", 100, 10);
            Product product5 = new Product(494, "Noodles", 500, 5);
            LineItem lineItem1 = new LineItem(1, 10, product4);
            LineItem lineItem2 = new LineItem(2, 10, product5);
            Order order = new Order(5, DateTime.Now);
            order.AddItem(lineItem1);
            order.AddItem(lineItem2);
            int expectedValue = order.Items.Count;
            Assert.AreEqual(expectedValue, order.Count);

        }

        [TestMethod]

        public void Test_CheckOutPrice_OrderMethod()
        {
            double expectedValue = 320;
            Product pro1 = new Product(11, "oil", 200, 20);
            LineItem li1 = new LineItem(111, 2, pro1);
            Order or = new Order(101, DateTime.Now);
            or.AddItem(li1);
            Assert.AreEqual(expectedValue, or.CheckOutPrice());

        }
    }
}
