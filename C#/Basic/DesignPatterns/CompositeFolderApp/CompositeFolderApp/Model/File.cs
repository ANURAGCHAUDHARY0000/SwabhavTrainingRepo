using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFolderApp.Model
{
    internal class File : IStorageType
    {
        private string _name;
        private int _size;

        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public void Display(int depth = 0)
        {
          Console.WriteLine(new String('-', depth) + Name + "|" + Size);
        }

        public string Name { get { return _name; } }

        public int Size { get { return _size; } }
    }
}
