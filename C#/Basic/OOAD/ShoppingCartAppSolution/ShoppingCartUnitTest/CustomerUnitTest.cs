using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCartLib.Model;

namespace ShoppingCartUnitTest
{
    [TestClass]
    public class CustomerUnitTest
    {
        [TestMethod]
        public void Test_Customer_Class_Constructor()
        {
            //Arrange
            int expectedCustomerid = 1234;
            string expectedCustomername = "Ram";
            //Act
            Customer customer = new Customer(1234, "Ram");
            //Assert
            Assert.AreEqual(expectedCustomername, customer.Name);
            Assert.AreEqual(expectedCustomerid, customer.Id);
        }

        [TestMethod]

        public void Order_Added_Test()
        {
            Product product4 = new Product(12, "DairyMilk", 100, 10);
            Product product5 = new Product(494, "Noodles", 50, 5);
            LineItem lineItem1 = new LineItem(1, 10, product4);
            LineItem lineItem2 = new LineItem(2, 20, product5);
            Order order = new Order(5, DateTime.Now);
            order.AddItem(lineItem1);
            order.AddItem(lineItem2);
            Customer ram = new Customer(1234, "Ram");
            ram.AddOrder(order);
            int expectedIntvalue = ram.Orders.Count;
            Assert.AreEqual(expectedIntvalue, ram.Count);
        }

        [TestMethod]

        public void Get_All_Customer_Order_Count()
        {
            Product pro1 = new Product(11, "oil", 200, 20);
            LineItem li1 = new LineItem(111, 2, pro1);
            Order or = new Order(101, DateTime.Now);
            or.AddItem(li1);
            Customer cus = new Customer(1234, "Ram");
            cus.AddOrder(or);
            Assert.IsTrue(or.Count == cus.GetOrders().Count);
        }
    }
}
