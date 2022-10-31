using System;

namespace MovieStoreApp.Model
{
    [Serializable]
    internal class Movie
    {
        private int _id;
        private string _name;
        private int _year;

        public Movie(Movie movie)
        {
            _id = movie.Id;
            _name = movie.Name;
            _year = movie.Year;
        }

         public Movie()
        {

        }

        public int Id { set { _id = value; } get { return _id; } }
        public string Name { set { _name = value; } get { return this._name; } }
        public int Year { set { _year = value; } get { return this._year; } }

    }

}

