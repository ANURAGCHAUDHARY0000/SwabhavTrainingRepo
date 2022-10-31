using System;

namespace EmployeePolymorphismApp.Model
{
    internal abstract class Employee
    {
        private int _id;
        private string _name;
        private int _basicSalary;

        public Employee(int id, string name, int basicSalary)
        {
            _id = id;
            _name = name;
            _basicSalary = basicSalary;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public int BasicSalary { get { return _basicSalary; } }

        public double AnnualBasicSalary { get { return (_basicSalary * 12); } }

        public abstract double CalculateAnnualSalary();
        public abstract String GetSalarySlip();
    }
}
