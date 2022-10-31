using System;
using EmployeeCsvReader.Model;

namespace EmployeeCsvReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            EmployeeService employeeService = new EmployeeService();
            EmployeeFileDataReader employeeFileDataReader = new EmployeeFileDataReader();
            Console.WriteLine("Employee Having Maximum Salary:");
            var employeePrinter = new PrintEmployeeDetails();
            employeePrinter.PrintEmployee(employeeService.MaxSalaryEmployee());
        }
    }
}
