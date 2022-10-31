using System;

namespace EmployeePolymorphismApp.Model
{
    internal class Manager : Employee
    {
        //private double hra; // 50 % of basic
        //private double ta; // 40 % of basic
        //private double da; // 30 % of basic
        //private double annualBasicSalary;
        public Manager(int id, string name, int basicSalary) : base(id, name, basicSalary)
        {

        }

        private double HRA { get { return (AnnualBasicSalary * 50)/100 ;}  }

        private double TA { get { return (AnnualBasicSalary * 40)/100 ;} }

        private double DA { get { return (AnnualBasicSalary * 30) / 100; } }

        //public override double CalculateAnnualSalary()
        //{
        //    annualBasicSalary = BasicSalary * 12;
        //    hra = (annualBasicSalary * 50) / 100;
        //    ta = (annualBasicSalary * 40) / 100;
        //    da = (annualBasicSalary * 30) / 100;
        //    return (annualBasicSalary + hra + ta + da);
        //}

        public override double CalculateAnnualSalary()
        {
            return (AnnualBasicSalary + HRA + TA + DA);
        }
        public override string GetSalarySlip()
        {
            String salarySlip = "";
            salarySlip = salarySlip + "Employee Id: " + Id + "\n";
            salarySlip = salarySlip + "Employee Name: " + Name + "\n";
            salarySlip = salarySlip + "Position: " + "Manager" + "\n";
            salarySlip = salarySlip + "Basic: " +  BasicSalary  + "\n";
            salarySlip = salarySlip + "HRA: " + HRA + "\n";
            salarySlip = salarySlip + "TA: " + TA + "\n";
            salarySlip = salarySlip + "DA: " + DA + "\n";
            salarySlip = salarySlip + "Total Annual Salary: " + CalculateAnnualSalary() + "\n";
            return salarySlip;

        }
    }
}
