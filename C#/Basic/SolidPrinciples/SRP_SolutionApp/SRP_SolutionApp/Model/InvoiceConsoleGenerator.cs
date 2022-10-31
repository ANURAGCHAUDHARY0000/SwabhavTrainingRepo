using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SRP_SolutionApp.Model
{
    internal class InvoiceConsoleGenerator
    {
       //public InvoiceConsoleGenerator(Invoice invoice)
       //{
       //     GenerateInvoice(invoice);
       //}
        public void GenerateInvoice(Invoice invoice)
        {

            Console.WriteLine("Invoice Id: {0}", invoice.Id);
            Console.WriteLine("Invoice Title: {0}", invoice.Title);
            Console.WriteLine("Invoice Amount: {0}", invoice.Amount);
            Console.WriteLine("Discount Percentage: {0}%", invoice.DiscountPercent);
            Console.WriteLine("Tax: {0}%", invoice.Tax );
            Console.WriteLine("Discounted amount: {0}", invoice.CalculateDiscountedAmount());
            Console.WriteLine("Tax amount: {0}", invoice.CalculateTaxAmount());
            Console.WriteLine("Final amount: {0}", invoice.CalculateFinalAmount());
            Console.WriteLine("----------------------------------------------------");

        }

       
    }
}
