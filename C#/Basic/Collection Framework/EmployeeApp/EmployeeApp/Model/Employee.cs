using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    internal class Employee
    {
        private readonly string _employeeNumber;
        private readonly string _employeeName;
        private readonly string _job;
        private readonly string _managerId;
        private readonly string _dateOfjoining;
        private readonly string _salary;
        private readonly string _commission;
        private readonly string _departmentNumber;


        public Employee(string employeeNumber, string employeeName, string job, string managerId, string dateOfjoining, string salary, string commission, string departmentNumber)
        {
            _employeeNumber = employeeNumber;
            _employeeName = employeeName;
            _job = job;
            _managerId = managerId;
            _dateOfjoining = dateOfjoining;
            _salary = salary;
            _commission = commission;
            _departmentNumber = departmentNumber;
        }
        public Employee()
        {

        }
        public string EmployeeNumber { get { return _employeeNumber; } }
        public string EmployeeName { get { return _employeeName; } }
        public string Job { get { return _job; } }
        public string ManagerId { get { return _managerId; } }
        public string DateOfjoining { get { return _dateOfjoining; } }
        public string Salary { get { return _salary; } }
        public string Commission { get { return _commission; } }
        public string DepartmentNumber { get { return _departmentNumber; } }


        public override string ToString()
        {
            return  EmployeeNumber + " " +  EmployeeName + " " +  Job + " " +
                ManagerId + " " + DateOfjoining + " " + Salary + " " +
                 Commission + " " + DepartmentNumber;

        }
    }
}