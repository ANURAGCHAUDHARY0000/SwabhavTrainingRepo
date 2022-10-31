using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFolderApp.Model
{
    internal class Folder : IStorageType
    {
        private string _name;
        private List<IStorageType> _children;

        public Folder(string name)
        {
            _name = name;
            _children = new List<IStorageType>();
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine(new String('-', depth) + _name);
            foreach (IStorageType type in _children)
            {
                type.Display(depth + 1);
            }
        }

        public void AddChild(IStorageType type)
        {
            _children.Add(type);
        }
    }
}
