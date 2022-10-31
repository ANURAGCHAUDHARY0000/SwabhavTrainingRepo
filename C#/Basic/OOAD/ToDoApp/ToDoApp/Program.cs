using System;
using ToDoApp.Model;
using System.Collections.Generic;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User Anurag = new User(1,"Anurag");
            ToDoItem item1 = new ToDoItem(101, "Assignment 1", "Yes",DateTime.Now);
            Anurag.AddToDo(item1);
            ToDoItem item2 = new ToDoItem(102, "Assignment 2", "Yes", DateTime.Now);
            Anurag.AddToDo(item2);
            PrintDetails(Anurag);
            Anurag.Remove(102);
          //  PrintDetails(Anurag);
        }

        public static void PrintDetails(User user)
        {
            Console.WriteLine("User Id :" +user.UserId);
            Console.WriteLine("User Name :" +user.Name);
            List<ToDoItem> itemlist = user.GetToDos();
            foreach (var item in itemlist)
            {
                Console.WriteLine($"Id : {item.Id}\nTitle : {item.Title}\nDateTime : " +
                    $"{item.Created}\nCompletion : {item.IsCompleted}");
            }

        }
        
    }
}
