using System;
using System.Collections.Generic;
using EmployeeApp.Service;
using EmployeeApp.Model;

namespace EmployeeApp
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
            EmployeeService emp = new EmployeeService();
            HashSet<Employee> employeeList = emp.GetEmployees();
            foreach (var employee in employeeList)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("-----------------------------------");
        }

        public static void CaseStudy2()
        {
            EmployeeService emp = new EmployeeService();
            IDictionary<string, int> jobWiseCount = emp.GetJobWiseCount();
            foreach (KeyValuePair<string, int> job in jobWiseCount)
            {
                Console.WriteLine($"{job.Key},{job.Value}");
            }
        }

    }
}


