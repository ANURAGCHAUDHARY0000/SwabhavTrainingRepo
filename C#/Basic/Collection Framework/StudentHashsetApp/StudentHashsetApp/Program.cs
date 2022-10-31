using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentHashsetApp.Model;


namespace StudentHashsetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        
        public static void CaseStudy1()
        {
            HashSet<String> locations = new HashSet<String>();
            locations.Add("Mumbai");
            locations.Add("mumbai");
            locations.Add("Mumbai");
            locations.Add("mumbai");
            

            foreach (String location in locations)
            {
                Console.WriteLine(location);
            }
            Console.WriteLine(locations.Count());
        }

        public static void CaseStudy2()
        {
            Student s1 = new Student(1, "Ram", "Chandra");
            Student s2 = new Student(1, "Ram", "Chandra");
            Student s3 = new Student(2, "pqr", "xyz");
            HashSet <Student> students = new HashSet<Student>();
            students.Add(s1);
            students.Add(s2); students.Add(s3);
            foreach(Student student in students)
            {
                Console.WriteLine("Student RollNo:{0}, Student FirstName:{1}, Student LastName: {2}", student.Rolno, student.FirstName, student.LastName);
            }
        }
        
    }
}
