using System;
using InterfaceRepositoryApp.Model;

namespace InterfaceRepositoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoingDbOperations(new CustomerRepository());
            DoingDbOperations(new InvoiceRepository());
            DoingDbOperations(new OrderRepository());
            
        }

        public static void DoingDbOperations(IRepository repo)
        {
            Console.WriteLine("Doing Db Operations");
            repo.Create();
            repo.Read();
            repo.Update();
            repo.Delete();

        }
    }
}
