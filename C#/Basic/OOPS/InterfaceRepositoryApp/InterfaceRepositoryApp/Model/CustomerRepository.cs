using System;


namespace InterfaceRepositoryApp.Model
{
    internal class CustomerRepository : IRepository
    {
        public  void Create()
        {
            Console.WriteLine("Customer order Created ");
        }

        public  void Read()
        {
            Console.WriteLine("Customer order Read ");

        }

        public  void Update()
        {
            Console.WriteLine("Customer order updated");
        }

        public  void Delete()
        {
            Console.WriteLine("Customer order deleted ");
        }
    }
}
