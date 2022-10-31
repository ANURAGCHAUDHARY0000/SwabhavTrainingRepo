using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CRUDOprUsingAdo
{
    internal class Program
    {

        // Creating Connection  
        static string cs = @"Data Source = .\SQLEXPRESS;Initial Catalog = Aurionpro;Integrated Security =true;";
         static SqlConnection con = new SqlConnection(cs);
        static void Main(string[] args)
        {
            //  ReadTable();
            //  UpdateTable();
            //  DeleteTableData();

            Console.WriteLine("\n\nMAIN MENU");
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("Type 1 to View All Records.");
            Console.WriteLine("Type 2 to Update Records.");
            Console.WriteLine("Type 3 to Delete Records.");
            Console.WriteLine("Type 4 to Create Data");

            string commandInput = Console.ReadLine();
            int command = Convert.ToInt32(commandInput);


            switch (command)
            {
               
                case 1:
                    ReadTable();
                    break;
                case 2:
                    UpdateTable();
                    break;
                case 3:
                    DeleteTableData();
                    break;
                case 4:
                    CreateTableData();
                    break ;
              
                default:
                    Console.WriteLine("\nInvalid Command. Please type a number from 1 to 4.\n");
                    break;
            }

        }


        static void ReadTable()
        {

            //    if(con.State == ConnectionState.Open)
            //    {
            //        Console.WriteLine("Connection has been established succesfully");
            //    }
          
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student;", con);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                string ID = sqlDataReader["StudentID"].ToString();
                string firstName = sqlDataReader["FirstName"].ToString();
                string lastName = sqlDataReader["LastName"].ToString();
                string address = sqlDataReader["Address"].ToString();
                string city = sqlDataReader["City"].ToString();
               

                Console.WriteLine(ID + " " + firstName + " " + lastName + " " +
                    address + " " + city);

            }
            sqlDataReader.Close();
            con.Close();
            Console.ReadLine();
            con.Close();
            
        }

        static void UpdateTable()
        {
            ReadTable();
            Console.WriteLine("\n\nPlease type Id of the record would like to update");
            string commandInput = Console.ReadLine();
            int Id = Int32.Parse(commandInput);
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            SqlCommand sql = new SqlCommand($"UPDATE Student SET FirstName = '{firstName}',LastName = '{lastName}',Address = '{address}',City = '{city}' WHERE  StudentID = '{Id}' ", con);
            con.Open();
            // Executing the SQL query  
            sql.ExecuteNonQuery();
            con.Close();
            ReadTable();

        }

        static void DeleteTableData()
        {
           ReadTable();
           Console.WriteLine("\n\nPlease type the Id of the record would like to delete");
           string commandInput = Console.ReadLine();
           int Id = Int32.Parse(commandInput);
           // writing sql query  
            SqlCommand cm = new SqlCommand($"delete from Student where StudentID = '{Id}' ", con);
          // Opening Connection  
            con.Open();
            // Executing the SQL query  
            cm.ExecuteNonQuery();
            con.Close();
            ReadTable();
        }

        static void CreateTableData()
        {
            ReadTable();
            Console.WriteLine("Enter Id"); 
            string commandInput = Console.ReadLine();
            int Id = Int32.Parse(commandInput);
             Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            // writing sql query  
            SqlCommand cm = new SqlCommand($"INSERT INTO Student  VALUES ('{Id}','{firstName}','{lastName}','{address}','{city}' )", con);

            // Opening Connection  
            con.Open();
            // Executing the SQL query  
            cm.ExecuteNonQuery();
            con.Close();
            ReadTable();


        }


       


    }
}


