using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP_SolutionApp.Model;
using System.IO;

namespace SRP_SolutionApp.Model
{
    internal class InvoiceHtmlGenerator
    {
        //public InvoiceHtmlGenerator(Invoice invoice)
        //{
        //    WriteHtmlFile(invoice);
        //}

        public void WriteHtmlFile(Invoice invoice)
        {
            String str = "<body><p>Invoice Id: " + invoice.Id + "</p><p>Invoice Title: " + invoice.Title + "</p>";
            str += "<p> Invoice Amount: " + invoice.Amount + "</p><p> Discount Percentage: " + invoice.DiscountPercent + "</p>";
            str += "<p> Tax: " + invoice.Tax + "</p><p> Discounted Amount: " + invoice.CalculateDiscountedAmount() + "</p>";
            str += "<p> Tax Amount: " + invoice.CalculateTaxAmount() + "</p><p> Final Amount: " + invoice.CalculateFinalAmount() + "</p>";
            str += "</body>";

            string path = @"D:\Swabhavtechlab\C#\Basic\SolidPrinciples\SRP_SolutionApp\SRP_SolutionApp\write.html";
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    using (StreamWriter streamWriter = new StreamWriter(fs))
            //    {
            //        streamWriter.Write(str);
            //    }
            //}
            File.WriteAllText(path, str);

        }
    }
}
