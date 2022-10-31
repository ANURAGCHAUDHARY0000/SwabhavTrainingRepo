using System;


namespace EmployeePolymorphismApp.Model
{
    internal class Analyst : Employee
    {
        //private double annualBasicSalary;
        //private double overTimeAllownces; //40 % of basic
        public  Analyst(int id , string name, int basicSalary) : base(id,name,basicSalary)
        {

        }

        private double OverTimeAllownces { get { return (AnnualBasicSalary * 40)/100; } }

        //public override double CalculateAnnualSalary()
        //{
        //    annualBasicSalary = BasicSalary * 12;
        //    overTimeAllownces = (annualBasicSalary * 40) / 100;
        //    return annualBasicSalary + overTimeAllownces;
        //}

        public override double CalculateAnnualSalary()
        {
            return AnnualBasicSalary + OverTimeAllownces;
        }
        public override string GetSalarySlip()
        {
            String SalarySlip = "";
            SalarySlip = SalarySlip + "Employee Id: " + Id + "\n";
            SalarySlip = SalarySlip + "Employee Name: " + Name + "\n";
            SalarySlip = SalarySlip + "Position: " + "Developer" + "\n";
            SalarySlip = SalarySlip + "Basic: " + BasicSalary + "\n";
            SalarySlip = SalarySlip + "Over Time Allowances: " + OverTimeAllownces + "\n";
            SalarySlip = SalarySlip + "Total Annual Salary: " + CalculateAnnualSalary() + "\n";
            return SalarySlip;
        }
    }
}
