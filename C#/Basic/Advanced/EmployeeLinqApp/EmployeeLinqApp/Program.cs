using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLinqApp.Model;

namespace EmployeeLinqApp
{
    internal class Program
    {
        private static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            var emp1 = new Employee { Id = 1, EmployeeName = "Anurag", Comm = 100, DOJ = "12/08/2020", DeptNo = 10, Salary = 2000 };
            var emp2 = new Employee { Id = 2, EmployeeName = "Anu", Comm = 10, DOJ = "13/08/2020", DeptNo = 122, Salary = 20000 };
            var emp3 = new Employee { Id = 3, EmployeeName = "Ram", Comm = 1000, DOJ = "15/08/2020", DeptNo = 20, Salary = 3000 };
            var emp4 = new Employee { Id = 4, EmployeeName = "Shyam", Comm = 20, DOJ = "16/08/2020", DeptNo = 20, Salary = 4000 };
            var emp5 = new Employee { Id = 5, EmployeeName = "Rama", Comm = 151, DOJ = "17/08/2020", DeptNo = 10, Salary = 5000 };
            var emp6 = new Employee { Id = 6, EmployeeName = "Mohan", Comm = 180, DOJ = "18/08/2020", DeptNo = 126, Salary = 6000 };
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);
            employees.Add(emp6);

            // AscendingOrderOfName();
            //  DescendingOrderOfSalary();
            //DisplayNameIdSalary();
            // DisplayNameSalaryAnnualSalary();
            DisplaySpecificEmployeeAccordingToDeptNo();

        }

        public static void AscendingOrderOfName()
        {
            var displayByascendingOrder = employees.OrderBy(e => e.EmployeeName);
            foreach (var employee in displayByascendingOrder)
            {
                Console.WriteLine(employee.Id + "," + employee.EmployeeName + "," + employee.Comm + "," +
                 employee.DOJ + "," + employee.DeptNo + "," + employee.Salary);
            }
        }

        public static void DescendingOrderOfSalary()
        {
           var displayBydescendingOrder  = employees.OrderByDescending(e => e.Salary);
            foreach (var employee in displayBydescendingOrder)
            {
                Console.WriteLine(employee.Salary + "," + employee.EmployeeName + "," + employee.Comm + "," +
                 employee.DOJ + "," + employee.DeptNo + "," + employee.Id);
            }
        }

        public static void DisplayNameIdSalary()
        {
            employees.Select((e) => new { MyName = e.EmployeeName, MyId = e.Id, MySalary = e.Salary })
                     .ToList()
                     .ForEach(e => Console.WriteLine(e.MyName +"  "+ e.MyId +"  "+ e.MySalary));
        }

        public static void DisplayNameSalaryAnnualSalary()
        {
            employees.Select((e) => new { MyName = e.EmployeeName, MyId = e.Id, MySalary = e.Salary,
                Commision = e.Comm ,AnnualSalary = (e.Salary +e.Comm) * 12 })
                    .ToList()
                    .ForEach(e => Console.WriteLine(e.MyName + "  " + e.MySalary + "  " + e.AnnualSalary));
        }

        public static void DisplaySpecificEmployeeAccordingToDeptNo()
        {
            var displaySpecificEmployee = employees.Where(e => e.DeptNo == 10 || e.DeptNo == 20);
            foreach (var employee in displaySpecificEmployee)
            {
                Console.WriteLine(employee.DeptNo + "," + employee.EmployeeName + "," + employee.Comm + "," +
                 employee.DOJ + "," + employee.Id + "," + employee.Salary);
            }
        }

    }
}
