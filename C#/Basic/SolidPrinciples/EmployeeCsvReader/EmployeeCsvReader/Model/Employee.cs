using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCsvReader.Model
{
    internal class Employee
    {
        private string _empId;
        private string _empName;
        private string _empDesignation;
        private string _empManagerId;
        private string _empDateOfJoining;
        private string _empSalary;
        private string _empCommission;
        private string _empDeptNumber;
        public Employee(string empId, string empName, string empDesignation, string empManager, string empDateofJoin, string salary, string empCommision, string empDept)
        {
            _empId = empId;
            _empName = empName;
            _empDesignation = empDesignation;
            _empManagerId = empManager;
            _empDateOfJoining = empDateofJoin;
            _empSalary = salary;
            _empCommission = empCommision;
            _empDeptNumber = empDept;
        }
        public string ID
        {
            get { return _empId; }
        }
        public string Name
        {
            get { return _empName; }
        }
        public string Designation
        {
            get { return _empDesignation; }
        }
        public string ManagerID
        {
            get { return _empManagerId; }
        }
        public string DateOfJoining
        {
            get { return _empDateOfJoining; }
        }
        public string Salary
        {
            get { return _empSalary; }
        }
        public string Commission
        {
            get { return _empCommission; }
        }
        public string DepartmentNumber
        {
            get { return _empDeptNumber; }
        }
        public override int GetHashCode()
        {
            return Convert.ToInt32(_empId);
        }
        public override bool Equals(object obj)
        {
            Employee emp = (Employee)obj;
            if (this.ID == emp.ID)
                return true;
            return false;
        }
    }
}
