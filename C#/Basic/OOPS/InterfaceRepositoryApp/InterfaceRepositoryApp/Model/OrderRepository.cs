using System;


namespace InterfaceRepositoryApp.Model
{
    internal class OrderRepository : IRepository
    {
        public void Create()
        {
            Console.WriteLine("Order Created ");
        }

        public void Delete()
        {
            Console.WriteLine("Order Deleted ");
        }

        public void Read()
        {
            Console.WriteLine("Order Read");
        }

        public void Update()
        {
            Console.WriteLine("Order Updated");
        }
    }
}
