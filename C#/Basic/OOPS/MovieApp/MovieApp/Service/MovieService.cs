using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MovieApp.Model;

namespace MovieApp.Service
{
    [Serializable]
    internal class MovieService
    {
        string[][] _movieList = new string[5][];
        public static int _count = 0;
        public static int _autoIdGenerate = 0;
        public void AddMovies()
        {
            
            Console.WriteLine("Movie Name : ");
             string _name = Console.ReadLine();

            Console.WriteLine("Movie Year : ");
            string _year = Console.ReadLine();

            string _id = "" + (++_autoIdGenerate);
            string[] movieData = new string[] { _id, _name, _year };
            _movieList[_count++] = movieData;
            SaveMovies();
        }

        public  void DisplayMovies()
        {
            for (int i = 0; i < _movieList.Length; i++)
            {
                if (_movieList[i] == null)
                {
                    break;
                }
                Console.WriteLine("Id: " + _movieList[i][0]);
                Console.WriteLine("Name: " + _movieList[i][1]);
                Console.WriteLine("Year: " + _movieList[i][2]);
            }
        }

        public void ClearAllMovies()
        {
            FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\OOPS\MovieApp\MovieApp\Write.txt", FileMode.Truncate);
            _count = 0;
            fileStream.SetLength(0);
            Console.WriteLine("All movies are deleted succesfully");
            fileStream.Close();
        }

        public void SaveMovies()
        {
            FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\OOPS\MovieApp\MovieApp\Write.txt", FileMode.Create);
            BinaryFormatter binaryObject = new BinaryFormatter();
            binaryObject.Serialize(fileStream, this);
            fileStream.Close();
        }

       

        //public static void Load()
        //{
        //    FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\OOPS\MovieApp\MovieApp\Write.txt", FileMode.OpenOrCreate);
        //    BinaryFormatter binaryObject = new BinaryFormatter();
        //    _movieList = (string[][])binaryObject.Deserialize(fileStream);
        //    fileStream.Close();
        //    for (int i = 0; i < _movieList.Length; i++)
        //    {
        //        //if (_movieList[i] == null)
        //        //{
        //        //    //_count = i;
        //        //    Console.WriteLine("-----------------");
        //        //    break;
        //        //}
        //        Console.WriteLine("Id: " + _movieList[i][0]);
        //        Console.WriteLine("Name: " + _movieList[i][1]);
        //        Console.WriteLine("Year: " + _movieList[i][2]);
        //    }
        // }

        //public int GetCount()
        //{
        //    FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\OOPS\MovieApp\MovieApp\Write.txt", FileMode.OpenOrCreate);
        //    BinaryFormatter binaryObject = new BinaryFormatter();
        //    _movieList = (string[][])binaryObject.Deserialize(fileStream);
        //    fileStream.Close();

        //    for (int i = 0; i < _movieList.Length; i++)
        //    {
        //        if(_movieList[i] == null)
        //        {
        //            _count = i;
        //            break;
        //        }

        //    }
        //    return _count;
        //}

        public int GetCount()
        {
            return _count;
        }
    }

}
