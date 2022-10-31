using System;
using System.Collections.Generic;
using MovieStoreApp.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieStoreApp.Service
{
    [Serializable]
    internal class MovieService
    {
        List <Movie> Movies = new List<Movie>();
        public static int _count = 0;
        public static int _autoIdGenerate = 0;

        public MovieService()
        {
            LoadMovies();
        }
        public void AddMovies()
        {
            if (Movies.Count == 5)
            {
                Console.WriteLine("Movie Store is full you can'nt add more movies");
                    return ;
            }
            try
            {
                Movie movie = new Movie();
                Console.WriteLine("Movie Name : ");
                movie.Name = Console.ReadLine();
                Console.WriteLine("Movie Year : ");
                movie.Year = Convert.ToInt32(Console.ReadLine());
                movie.Id = ++_autoIdGenerate;
                Movies.Add(new Movie(movie));
                SaveMovies();
            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter Valid Input ");
                Console.ResetColor();
            }
        }

        public  void SaveMovies()
        {
            FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\Collection Framework\MovieStoreApp\MovieStoreApp\Write.txt", FileMode.Create);
            BinaryFormatter binaryObject = new BinaryFormatter();
            binaryObject.Serialize(fileStream, Movies);
            fileStream.Close();
        }


        public void DisplayMovies()
        {
          
            foreach (Movie movie in Movies)
            {
                if(movie == null)
                {
                    break;
                }
                Console.WriteLine("Movie Id :" + movie.Id);
                Console.WriteLine("Movie Name :" +movie.Name);
                Console.WriteLine("Movie Year :" +movie.Year);
                Console.WriteLine("------------------------");
            }
           
        }

        public void LoadMovies()
        {
            
            FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\Collection Framework\MovieStoreApp\MovieStoreApp\Write.txt", FileMode.Open);
            BinaryFormatter binaryObject = new BinaryFormatter();
            if (fileStream.Length == 0)
            {
                Movies = new List<Movie>();
                fileStream.Close();
            }
            else
            {
                Movies = (List<Movie>)binaryObject.Deserialize(fileStream);
                _count = Movies.Count;
                fileStream.Close();
            }


        }

        public void ClearAllMovies()
        {
            FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\Collection Framework\MovieStoreApp\MovieStoreApp\Write.txt", FileMode.Truncate);
            _count = 0;
            fileStream.SetLength(0);
            Console.WriteLine("All movies are deleted succesfully");
            fileStream.Close();
        }


    }
}
