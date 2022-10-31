using System;
using System.IO;
using System.Collections.Generic;

namespace EmployeeCsvReader.Model
{
    internal class EmployeeFileDataReader
    {
        HashSet<String> employeeDetails = new HashSet<string>();
        public EmployeeFileDataReader()
        {
            ReadDetails();
        }

        public void ReadDetails()
        {
            string path = @"D:\Swabhavtechlab\C#\Basic\SolidPrinciples\EmployeeCsvReader\EmployeeCsvReader\Employees.csv";
            string details;
            StreamReader reader = new StreamReader(path);
            details = reader.ReadLine();

            while (details != null)
            {
                employeeDetails.Add(details);
                details = reader.ReadLine();
            }
            reader.Close();

            FileReader();
        }
        public void FileReader()
        {
            EmployeeService employeeService = new EmployeeService();
            foreach (String detail in employeeDetails)
            {
                char[] commaSeparators = new char[] { ',' };
                String[] details = detail.Split(commaSeparators);
                employeeService.AddEmployee(new Employee(details[0], details[1], details[2], details[3], details[4],
                details[5], details[6], details[7]));
            }

        }

    }
}
