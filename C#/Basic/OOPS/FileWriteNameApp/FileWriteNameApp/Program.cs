using System;
using System.IO;

namespace FileWriteNameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Swabhavtechlab\C#\Basic\OOPS\FileWriteNameApp\FileWriteNameApp\WriteName.txt";
            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    Console.WriteLine("Enter name:");
                    string name = Console.ReadLine();
                    writer.WriteLine(name);
                }
            }
        }
    }
}