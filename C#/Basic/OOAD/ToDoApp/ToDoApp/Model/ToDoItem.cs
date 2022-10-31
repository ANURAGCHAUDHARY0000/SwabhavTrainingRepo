using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Model
{
    internal class ToDoItem
    {
        private int _id;
        private string _title;
        private DateTime _created;
        private string _isCompleted;


       public ToDoItem(int id, string title, string isCompleted,DateTime created)
       {
            _id = id;
            _title = title;
           _isCompleted = isCompleted;
            _created = created;
       }
       public int Id { get { return _id; } }   

       public string Title { get { return _title; } }

       public DateTime Created { get { return _created; } }

      public string IsCompleted { get { return _isCompleted; } }

    }
}
