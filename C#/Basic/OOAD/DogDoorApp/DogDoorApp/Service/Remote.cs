﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogDoorApp.Model;
namespace DogDoorApp.Service
{
    internal class Remote
    {

		private DogDoor door;

		public Remote(DogDoor door)
		{
			this.door = door;
		}

		public void pressButton()
		{
            Console.WriteLine("Pressing the remote control button...");
			if (door.isOpen())
			{
				door.close();
			}
			else
			{
				door.open();
			}
		}
	}
}
