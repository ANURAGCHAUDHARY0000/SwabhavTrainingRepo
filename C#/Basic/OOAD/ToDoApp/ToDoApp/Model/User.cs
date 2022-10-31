using System;
using System.Collections.Generic;
using System.Linq;


namespace ToDoApp.Model
{
    internal class User
    {

        private int _id;
        private string _name;
        private List<ToDoItem> _todos;

        public User(int id, string name)
        {
            _id = id;
            _name = name;
            _todos = new List<ToDoItem>();
        }

        public int UserId { get { return _id; } }
        public string Name { get { return _name; } }
        

        public void AddToDo(ToDoItem item)
        {
            _todos.Add(item);
        }

        public List<ToDoItem> GetToDos()
        {
            List<ToDoItem> todos = new List<ToDoItem>();
            foreach (ToDoItem item in _todos)
            {
                todos.Add(item);
            }
            return todos;
        }

        public void Remove(int id)
        {
            foreach (ToDoItem item in _todos.ToList())
            {
                if(item.Id == id)
                _todos.Remove(item);
            }
        }

        //public override string ToString()
        //{
           
        //    foreach (ToDoItem item in _todos)
        //    {
        //        Console.WriteLine($"Id : {item.Id}\nTitle : {item.Title}\nDateTime : " +
        //            $"{item.Created}\nCompletion : {item.IsCompleted}");
        //    }
        //    return $"User Id : {UserId}\nUser Name : {Name}";
        //}
    }
}
