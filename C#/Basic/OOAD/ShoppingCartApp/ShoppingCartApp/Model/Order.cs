using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Model
{
    internal class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> _items;
       

        public Order(int id, DateTime date)
        {
            _id = id;
            _date = date;
            _items = new List<LineItem>();
        }

        public void AddItem(LineItem item)
        {
            _items.Add(item);
        }

        public double CheckOutPrice()
        {
            double _checkOutcost = 0;

            foreach (LineItem item in _items)
            {
                _checkOutcost = _checkOutcost + item.CalculateItemPrice();
            }
            return _checkOutcost;
        }

        public int Id { get { return _id; } }

        public DateTime Date { get { return _date; } }

        public List<LineItem> Items { get { return _items; } }
    }
}
