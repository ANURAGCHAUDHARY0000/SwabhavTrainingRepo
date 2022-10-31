using System;
using EmployeePolymorphismApp.Model;
using System.IO;



namespace EmployeePolymorphismApp
{
    internal class PolymorphismTest
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager(1,"Anurag",24000);
            Console.WriteLine(m1.GetSalarySlip());

            Console.WriteLine("-------------------------------");

            Developer d = new Developer(2, "Ram", 20000);
            Console.WriteLine(d.GetSalarySlip());

            Console.WriteLine("-------------------------------");

            Analyst a = new Analyst(3, "shyam", 18000);
            Console.WriteLine(a.GetSalarySlip());
          
            WriteHtmlFile(m1.GetSalarySlip(), @"D:\Swabhavtechlab\C#\Basic\OOPS\EmployeePolymorphismApp\EmployeePolymorphismApp\Write.html");


            // PrintSalarySlip(m1);

            //Developer d = new Developer(2,"Ram",20000);
            //PrintSalarySlip(d);

            //Analyst a = new Analyst(3, "shyam", 18000);
            //PrintSalarySlip(a);
        }

        public static void WriteHtmlFile(String content, String path)
        {
           
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fs))
                {
                    streamWriter.Write(content);
                    

                }

            }
        }

        //public static void PrintSalarySlip(Employee employee)
        //{
        //    Console.WriteLine("Employee id  : " + employee.Id);
        //    Console.WriteLine("Employee name : " + employee.Name);
        //    Console.WriteLine("Employee basic salary : "+employee.BasicSalary);
        //    Console.WriteLine("Employee annual salary :"+employee.CalculateAnnualSalary());
        //    Console.WriteLine();
        //}
    }
}
