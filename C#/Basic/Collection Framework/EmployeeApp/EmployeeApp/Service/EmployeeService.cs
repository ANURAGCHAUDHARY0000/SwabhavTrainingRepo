using System;
using System.Collections.Generic;
using EmployeeApp.Model;
using System.IO;
using System.Configuration;

namespace EmployeeApp.Service
{
    internal class EmployeeService
    {
        Employee employee;
        HashSet<String> employeeDetails = new HashSet<string>();
        HashSet<Employee> employees = new HashSet<Employee>();
        string path = ConfigurationManager.AppSettings.Get("BasePath");

        public EmployeeService()
        {
            ReadDetails();
        }
        public void ReadDetails()
        {
            string details;
            StreamReader reader = new StreamReader(path + @"\employee.csv");
            details = reader.ReadLine();

            while (details != null)
            {
                employeeDetails.Add(details);
                details = reader.ReadLine();
            }
            reader.Close();

        }

        public HashSet<Employee> GetEmployees()
        {
            foreach (String detail in employeeDetails)
            {
                char[] commaSeparators = new char[] {','};
                String[] details = detail.Split(commaSeparators);
                employee = new Employee(details[0], details[1], details[2], details[3], details[4],
                details[5], details[6], details[7]);
                employees.Add(employee);
            }
            return employees;
        }


        public Dictionary<string, int> GetJobWiseCount()
        {
            Dictionary<string, int> valuesAndCounts = new Dictionary<string, int>();
            foreach (var employee in GetEmployees())
            {
                
                if (!valuesAndCounts.ContainsKey(employee.Job))
                {
                    if (valuesAndCounts.Values != null)
                    {
                        valuesAndCounts.Add(employee.Job, 1);
                    }
                }
               else if(valuesAndCounts.ContainsKey(employee.Job))
                {
                    if (valuesAndCounts.Values != null)
                    {
                        valuesAndCounts[employee.Job]++;
                    }
                }
            }
            return valuesAndCounts;
        }

    }
}
