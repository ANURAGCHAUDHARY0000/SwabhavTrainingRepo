using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // creating a connection string
            string connection = @"server = .\SQLEXPRESS;
                                 database =  Aurionpro;
                                 integrated security = SSPI";



            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from EMP;", con);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                string empNo = sqlDataReader["EMPNO"].ToString();
                string empName = sqlDataReader["ENAME"].ToString();
                string Job = sqlDataReader["JOB"].ToString();
                string mgr = sqlDataReader["MGR"].ToString();
                string hireDate = sqlDataReader["HIREDATE"].ToString();
                string salary = sqlDataReader["SAL"].ToString();
                string commission = sqlDataReader["COMM"].ToString();
                string deptNo = sqlDataReader["DEPTNO"].ToString();

                Console.WriteLine(empNo + " " + empName + " " + Job + " "+
                    mgr + " " + hireDate + " " + salary + " " + commission + " " +
                    commission + " " + deptNo);
            }
            sqlDataReader.Close();
            con.Close();
            Console.ReadLine();
        }
    }
}
