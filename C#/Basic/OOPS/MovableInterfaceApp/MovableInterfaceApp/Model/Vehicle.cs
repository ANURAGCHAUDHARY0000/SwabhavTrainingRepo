using System;


namespace MovableInterfaceApp.Model
{
      internal abstract class Vehicle : Imovable
      {
        protected string _name;

        public abstract void Move();

        public Vehicle (string name)
        {
            _name = name;
        }
      }
}
