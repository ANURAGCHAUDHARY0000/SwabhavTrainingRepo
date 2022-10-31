using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorAppV1._0.Model
{
    internal class DogDoor
    {
        private bool _open;
        public DogDoor()
        {
            this._open = false;
        }

        public void Open()
        {
            Console.WriteLine("\n The Dog Door opens");
            _open = true;
        }

        public void Close()
        {
            Console.WriteLine("\n The Dog Door Closed.");
            _open = false;
        }

        public bool IsOpen()
        {
            return _open;
        }
    }
}
