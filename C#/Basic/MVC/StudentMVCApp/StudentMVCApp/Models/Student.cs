using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMVCApp.Models
{
    public class Student
    {

        private int id;
        private string firstName;
        private string lastName;
        private int cgpa;

        public Student() { }

        public Student(int id, string firstName, string lastName, int cgpa)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.cgpa = cgpa;
        }

        public int Id { get { return id; } set { id = value; } }

        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }

        public int CGPA { get { return cgpa; } set { cgpa = value; } }
    }
}