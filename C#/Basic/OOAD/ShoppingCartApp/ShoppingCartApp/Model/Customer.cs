using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Model
{
    internal class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _orders;

        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
           _orders = new List<Order>();
        }

       
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            foreach (Order order in _orders)
            {
                orders.Add(order);
            }
            return orders;
        }

        public int Id { get { return _id; } }

        public string Name { get { return _name; } }


    }
}
