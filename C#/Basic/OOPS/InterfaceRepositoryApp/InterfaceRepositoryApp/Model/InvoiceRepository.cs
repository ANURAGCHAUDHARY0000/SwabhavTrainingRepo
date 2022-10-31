using System;

namespace InterfaceRepositoryApp.Model
{
    internal class InvoiceRepository : IRepository
    {
        public void Create()
        {
            Console.WriteLine(" Invoice Created ");
        }

        public void Delete()
        {
            Console.WriteLine("Invoice deleted ");
        }

        public void Read()
        {
            Console.WriteLine("Invoice Read");
        }

        public void Update()
        {
            Console.WriteLine("Invoice Updated");
        }
    }
}
