using System;
using MovieApp.Service;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace MovieApp
{
    [Serializable]
    internal class Program
    {
        
        public static void Main(string[] args)
        {
           Console.WriteLine("Welcome to movie store app developed by: Anurag");
           MovieStore();
        }
        public static void MovieStore()
        {

            FileStream fileStream = new FileStream(@"D:\Swabhavtechlab\C#\Basic\OOPS\MovieApp\MovieApp\Write.txt", FileMode.Open);
            BinaryFormatter binaryObject = new BinaryFormatter();
            _movieList = (string[][])binaryObject.Deserialize(fileStream);
            fileStream.Close();
            Program p = new Program();
            p.Menu();
        }
        public  void Menu()
        {
            while (true)
            {
                Console.WriteLine("Movie count: " + movieService.GetCount());
                Console.WriteLine("1. Add movie\n2. Display movies\n3. Clear all movies\n4. Exit");
                int choice;
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                            movieService.AddMovies();
                    }
                    else if (choice == 2)
                        movieService.DisplayMovies();
                    else if (choice == 3)
                        movieService.ClearAllMovies();
                    else if (choice == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Choice");
                    }
                }
                catch(FormatException )
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        
    }
}
