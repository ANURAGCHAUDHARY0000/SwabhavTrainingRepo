using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Model
{
    internal class Employee
    {
        private int _id;
        private string _name;
        public Employee(string name, int id)
        {
            _name = name;
            _id = id;
        }
        public int ID { get { return _id; } }
        public string Name { get { return _name; } }
       
    }
}
