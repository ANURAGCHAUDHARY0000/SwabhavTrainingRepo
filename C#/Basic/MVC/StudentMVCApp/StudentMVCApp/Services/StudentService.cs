using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentMVCApp.Models;

namespace StudentMVCApp.Services
{
    public class StudentService
    {
        private static List<Student> listOfStudent = new List<Student>();

        static StudentService()
        {
            listOfStudent.Add(new Student(1,"Anurag","Chaudhary",7));
            listOfStudent.Add(new Student(2, "Ram", "Kumar", 8));
            listOfStudent.Add(new Student(3, "Krishna", "Kumar", 9));
            listOfStudent.Add(new Student(4, "Shyam", "Maurya", 10));
        }

        public List<Student> GetStudents()
        {
             return listOfStudent;

        }

        public void AddStudent(Student s)
        {
            listOfStudent.Add(s);

        }

        public int GetHeadCount()
        {
            return listOfStudent.Count();
        }

        public Student GetStudentById(int id)
        {
            var studentList = listOfStudent.Where(x => x.Id == id).Single();
            return studentList;
        }

        public void Remove(int id)
        {
            var studentList = listOfStudent.Where(x => x.Id != id).ToList();
        }

       
        public void Update(Student stu)
        {
            var stu1 = listOfStudent.Where(s => s.Id == stu.Id).Single();
            listOfStudent.Remove(stu1);
            listOfStudent.Add(stu);
        }

    }
}