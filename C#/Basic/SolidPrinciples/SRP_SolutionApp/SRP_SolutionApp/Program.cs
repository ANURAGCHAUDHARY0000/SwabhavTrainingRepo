using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP_SolutionApp.Model;

namespace SRP_SolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1001, "Restaurant Bill", 1000, 5);
            InvoiceConsoleGenerator printInvoice = new InvoiceConsoleGenerator();
            printInvoice.GenerateInvoice(invoice);
            InvoiceHtmlGenerator htmlGenerator = new InvoiceHtmlGenerator();
            htmlGenerator.WriteHtmlFile(invoice);
        }
    }
}

