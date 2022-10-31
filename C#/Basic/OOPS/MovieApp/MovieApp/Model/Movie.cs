using System;

namespace MovieApp.Model
{
    [Serializable]
    internal class Movie
    {
        private int _id;
        private string _name;
        private int _year;

        public Movie(int id, string name, int year)
        {
            _id = id;
            _name = name;
            _year = year;
        }

        public int Id { get { return _id; } }
        public string Name { get { return this._name; } } 
        public int Year { get { return this._year; } }
    }
}
