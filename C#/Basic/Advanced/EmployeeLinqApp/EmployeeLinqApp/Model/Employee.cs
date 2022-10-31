using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLinqApp.Model
{
    internal class Employee
    {
        private int _employeeId;
        private String _employeeName;
        private double _salary;
        private string _doj;
        private int _deptNo;
        private double comm;


        public int Id
        {
            set { _employeeId = value; }
            get { return _employeeId; }
        }

        public String EmployeeName
        { get { return _employeeName; } set { _employeeName = value; } }

        public double Salary { get { return _salary; } set { _salary = value; } }

        public string DOJ { get { return _doj; } set { _doj = value; } }

        public int DeptNo { get { return _deptNo; } set { _deptNo = value; } }

        public double Comm { get { return comm; } set { comm = value; } }   


    }
}
