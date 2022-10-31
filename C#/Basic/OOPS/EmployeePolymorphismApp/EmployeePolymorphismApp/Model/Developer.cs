using System;

namespace EmployeePolymorphismApp.Model
{
    internal class Developer : Employee
    {
        //private double projectIncentive; // 50 % 0f basic 
        //private double ta;               // 40 % of basic
        //private double annualBasicSalary;
        public Developer(int id, string name, int basicSalary) : base(id, name, basicSalary)
        {
            
        }

        private double ProjectIncentive { get{ return (AnnualBasicSalary * 50) / 100; } }

        private double TA { get { return (AnnualBasicSalary * 40) / 100; } }

        //public override double CalculateAnnualSalary()
        //{
        //    annualBasicSalary = BasicSalary * 12;
        //    projectIncentive = (annualBasicSalary * 50) / 100;
        //    ta = (annualBasicSalary * 40) / 100;
        //    return (annualBasicSalary + projectIncentive + ta);
        //}

        public override double CalculateAnnualSalary()
        {
            return AnnualBasicSalary + ProjectIncentive + TA;
        }


        public override string GetSalarySlip()
        {
            String SalarySlip = "";
            SalarySlip = SalarySlip + "Employee Id: " + Id + "\n";
            SalarySlip = SalarySlip + "Employee Name: " + Name + "\n";
            SalarySlip = SalarySlip + "Position: " + "Developer" + "\n";
            SalarySlip = SalarySlip + "Basic: " + BasicSalary + "\n";
            SalarySlip = SalarySlip + "Project Incentive: " + ProjectIncentive  + "\n";
            SalarySlip = SalarySlip + "TA: " + TA + "\n";
            SalarySlip = SalarySlip + "Total Annual Salary: " + CalculateAnnualSalary() + "\n";
            return SalarySlip;

        }
    }
}
