using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListApp.Model
{
    internal class Student
    {
        private int _id;
        private string _name;
        private double _cgpa;
        private string _location;

        public Student(int id, string name, double cgpa, string location)
        {
            _id = id;
            _name = name;
            _cgpa = cgpa;
            _location = location;
        }

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        
        public double CGPA { get { return _cgpa; } }

        public string Location { get { return _location; } }



    }
}
