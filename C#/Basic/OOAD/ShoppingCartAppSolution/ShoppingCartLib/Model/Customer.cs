using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    public class Customer
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

        public int Id { get { return _id; } }

        public string Name { get { return _name; } }

        public List<Order> Orders { get { return _orders; } }

        public int Count { get { return _orders.Count; } }

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

       

    }
}
