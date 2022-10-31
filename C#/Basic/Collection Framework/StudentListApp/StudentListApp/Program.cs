using System;
using System.Collections.Generic;
using StudentListApp.Model;

namespace StudentListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Student> students = new List<Student>();
            students.Add(new Student(1, "Krishna", 9.8, "Mumbai"));
            students.Add(new Student(2, "Radha", 9, "Kolkata"));
            students.Add(new Student(3, "Balram", 6, "Delhi"));
            students.Add(new Student(4, "Shyama", 7, "Vrindavan"));
            students.Add(new Student(5, "Sita", 5, "Mumbai"));
            GetStudentWithHighCgpa(students);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Printining Details of Mumbai Residents");
            Console.WriteLine("-------------------------------");
            GetStudentsInMumbai(students);
        }

        public static void GetStudentWithHighCgpa(List <Student> students)
        {
            List<Student> highCgpa = new List<Student>();
            foreach (var student in students)
            {
                if(student.CGPA >= 8)
                {
                    highCgpa.Add(student);
                }
            }

            PrintDetails(highCgpa);
        }

        public static void GetStudentsInMumbai(List<Student> students)
        {
            List<Student> mumbaiResidents = new List<Student>();
            foreach (var student in students)
            {
                if(student.Location.Equals("Mumbai"))
                {
                    mumbaiResidents.Add(student);
                }
            }
            PrintDetails(mumbaiResidents);
        }

        public static void PrintDetails(List<Student> students)
        {
           foreach(var student in students)
            {
                Console.Write("Id: " + student.Id);
                Console.Write("\tName: " + student.Name);
                Console.Write("\tCGPA: " + student.CGPA);
                Console.Write("\tLocation: " + student.Location);
                Console.WriteLine();
            }


        }
    }
}
