using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP_ViolationApp.Model;

namespace SRP_ViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1001, "Restaurant Bill", 1000, 5);
            invoice.PrintInvoice();
            invoice.WriteHtmlFile();

        }
    }
}
