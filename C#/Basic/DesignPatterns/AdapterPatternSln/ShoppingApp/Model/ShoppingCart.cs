using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{
    internal class ShoppingCart
    {
        private List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
        public List<IItem> Items
        {
            get
            {
                return items;
            }
        }

        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach(IItem item in items)
            {
                totalPrice += item.ItemPrice();
            }
            return totalPrice;

        }
    }
}
