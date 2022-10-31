using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeFolderApp.Model;


namespace CompositeFolderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var movies = new Folder("Movies");
            movies.AddChild(new File("Titanic.avi", 700));

            var action = new Folder("Action");
            movies.AddChild(action);
            movies.AddChild(new File("Terminator.mp4", 4000));

            var comedy = new Folder("Comedy");
            movies.AddChild(comedy);
            comedy.AddChild(new File("Golmaal.avi", 1000));

            movies.Display();
        }
    }
}
