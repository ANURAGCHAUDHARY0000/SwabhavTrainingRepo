using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHashsetApp.Model
{
    internal class Student
    {
        private int _roolno;
        private string _firstName;
        private string _lastName;

        public Student(int roolno, string firstName, string lastName)
        {
            _roolno = roolno;
            _firstName = firstName;
            _lastName = lastName;
        }

        public int Rolno { get { return _roolno; } }
        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }


        public override bool Equals(object obj)
        {
            Student student = (Student)obj;
            if(Rolno != student.Rolno){ return false; }
            if(FirstName != student.FirstName){ return false; }
            if(LastName != student.LastName){ return false; }
            return true;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            int result = 1;
            result = hash * 31 + Rolno.GetHashCode();
            result = hash * 31 + FirstName.GetHashCode();
            return result;
        }
    }
}
