using System;
using DogDoorAppV1._0.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace DogDoorAppV1._0.Service
{
    internal class Remote
    {
       private DogDoor _door;
       private Timer _timer = new Timer(5000);

        public Remote(DogDoor door)
        {
            this._door = door;
        }
        public void pressButton()
        {
            Console.WriteLine("Pressing the remote control button ...");
            DoorCondition();
            AutoCloseDoor();
        }
        private void DoorCondition()
        {
            if (_door.IsOpen())
            {
                _door.Close();
            }
            else
            {
                _door.Open();
            }
        }
        private void AutoCloseDoor()
        {
            _timer.Enabled = true;
        }

        private void _timer_Elapsed_CloseDoor(object sender, ElapsedEventArgs e)
        {
            _door.Close();
            _timer.Enabled = false;
        }
    }
}