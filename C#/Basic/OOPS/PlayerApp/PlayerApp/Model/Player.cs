using System;

namespace PlayerApp.Model
{
    internal class Player
    {
        private readonly int _id;
        private readonly string _name;
        private int _age;
        public static int _instanceCount = 0;

        public Player(int id, String name) : this(id, name, 18)
        {
        }
        public Player(int id, String name, int age)
        {

            this._id = id;
            this._name = name;
            this._age = age;

        }

        public Player()
        {
            Player._instanceCount += 1;
            
        }

        public int InstanceCount
        {
            get { return Player._instanceCount; }
        }

        public static int HeadCount
        {
            get
            {
                return Player._instanceCount;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }

        public Player WhoIsElder(Player player)
        {
            //if (_age > player.Age)
            //{
            //    return this;
            //}
            //return player;

            return _age > player.Age ? this : player;

        }


    }
}
