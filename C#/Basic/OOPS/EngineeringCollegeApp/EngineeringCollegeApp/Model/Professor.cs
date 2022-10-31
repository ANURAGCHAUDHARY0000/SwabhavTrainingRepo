using System;

namespace EngineeringCollegeApp.Model
{
    internal class Professor : Person, ISalaryCalculator
    {
        private double HRA;
        private double TA;
        private double DA;
        private double salary;
        public Professor(int id, string address, string dob) : base(id, address, dob)
        {

        }

        public double CalculateSalary(double _annualBasicsalary) 
        {
            HRA = (_annualBasicsalary * 50) / 100;
            TA = (_annualBasicsalary * 40) / 100;
            DA = (_annualBasicsalary * 30) / 100;
            salary = _annualBasicsalary + HRA + TA + DA;
            return salary;
        }

       public double Salary { get { return salary; } }

        public override string ToString()
        {
            String professorDetails = "Professor Details \n";
            professorDetails += "Id: " + Id + "\n";
            professorDetails += "Address: " + Address + "\n";
            professorDetails += "DOB: " + Dob + "\n";
            professorDetails += "Salary: " + Salary + "\n";
            return professorDetails;
        }



    }
}
