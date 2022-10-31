using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
    internal class DogDoor
    {
        private bool  _open;
        public DogDoor()
        {
            this._open = false;
        }

        public void open()
        {
            Console.WriteLine ("\n The Dog Door opens");
             _open = true;
        }

        public void close()
        {
            Console.WriteLine("\n The Dog Door Closed.");
            _open = false;
        }

        public bool isOpen()
        {
            return _open;
        }
    }
}
