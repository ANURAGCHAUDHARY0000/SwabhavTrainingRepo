using System;
using EngineeringCollegeApp.Model;

namespace EngineeringCollegeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student(1, "Varansi", "18/10/2002",
            Branch.InformationTechnology);
            //    Console.WriteLine(student.GetDetails());
            //  Console.WriteLine( GetDetails(student));

            Professor prof = new Professor(2, "ParthaGoswami DTU", "19/05/1989");
            prof.CalculateSalary(224000);

            Console.WriteLine(student);
            Console.WriteLine(prof);


        }


        //public static string GetDetails(Student p)
        //{
        //    String Details = "Details of student\n";
        //    Details += "Id: " + p.Id + "\n";
        //    Details += "Address: " + p.Address + "\n";
        //    Details += "DOB: " +p. Dob + "\n";
        //    Details += "Branch: " + p.Branch + "\n";
        //    return Details;
        //}

    }
}


