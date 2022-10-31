using System;
using MovieStoreApp.Service;

namespace MovieStoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Movie Store App developed by: Anurag");
            Menu();
        }
        public static void Menu()
        {
         
            while (true)
            {
                MovieService movieService = new MovieService();
                Console.WriteLine("Movie count: " + MovieService._count);
                Console.WriteLine("1. Add movie\n2. Display movies\n3. Clear all movies\n4. Exit");
                Console.WriteLine("Enter Your Choice");
                try
                {
                    int choice;
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                        movieService.AddMovies();
                    else if (choice == 2)
                        movieService.DisplayMovies();
                    else if (choice == 3)
                        movieService.ClearAllMovies();
                    else if (choice == 4)
                        break;
                    else
                        Console.WriteLine("Wrong Choice");
                }
                catch(FormatException )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter Valid Input");
                    Console.ResetColor();
                  
                }
            }
        }
    }
}
