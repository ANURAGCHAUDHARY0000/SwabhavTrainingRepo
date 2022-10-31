using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Model
{

    internal class Iterator : IAbstractIterator
    {
        private ConcreteCollection collection;
        private int _current = 0;
        private int _step = 1;
       
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
       
        public Employee First()
        {
            _current = 0;
            return collection.GetEmployee(_current);
        }
        // Gets next item
        public Employee Next()
        {
            _current += _step;
            if (!IsCompleted)
            {
                return collection.GetEmployee(_current);
            }
            else
            {
                return null;
            }
        }
        // Check whether iteration is complete
        public bool IsCompleted
        {
            get { return _current >= collection.Count; }
        }

    }
}
