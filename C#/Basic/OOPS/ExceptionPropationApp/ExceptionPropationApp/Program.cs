using System;

namespace ExceptionPropationApp
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                M1();
            }
            catch(Exception ex)
            {
                  
              Console.WriteLine("Display Error Message");
              Console.ForegroundColor = ConsoleColor.Red;  
              Console.WriteLine(ex.Message);
              Console.WriteLine(ex.StackTrace);
            }
            Console.ResetColor();
            Console.WriteLine("End of Main");
           
        }
        public static void M1()
        {

            Console.WriteLine("Inside M1");
            M2();
        }
        public static void M2()
        {
            Console.WriteLine("Inside M2");
            M3();
        }

        public static void M3()
        {
            Console.WriteLine("Inside M3");
            throw new Exception("Something Went wrong in m3");
        }

    }
}
