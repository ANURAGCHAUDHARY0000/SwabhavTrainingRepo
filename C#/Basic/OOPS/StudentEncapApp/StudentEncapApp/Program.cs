using System;
using StudentEncapApp.Model;
namespace StudentEncapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Student stu = new Student();
          stu.SetRollNumber(1);
          stu.SetName("Krishna");
          stu.SetCgpa(9.4f);
          stu.SetTotalFees(100000);
          stu.PayFees(20000);
          stu.PayFees(30000);
          Console.WriteLine("Student name is : {0}\nStudent Roll number is : {1}\nStudent cgpa is :{2}\nStudent Percentage is : {3}\nStudent Total Fees is : {4}\nStudent Remaining Fees is :{5}",
          stu.GetName(),stu.GetRollNo(),stu.GetCgpa(),stu.CalculatePercentageFromCgpa(),stu.GetTotalFees(),stu.GetRemainingFees());
        }
    }
}
