using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SRP_ViolationApp.Model
{
    internal class Invoice
    { 
        private int _id;
        private string _title;
        private double _amount;
        private int _discountPercent;
        private float _tax = 18;

        public Invoice(int id, string title, double amount, int discountPercent)
        {
            _id = id;
            _title = title;
            _amount = amount;
            _discountPercent = discountPercent;
        }

        public double CalculateFinalAmount()
        {
             return (_amount - CalculateDiscountedAmount()) + CalculateTaxAmount();
        }

        public double CalculateDiscountedAmount()
        {
            return  _amount * _discountPercent / 100 ;
        }

        public double CalculateTaxAmount()
        {
            return _amount * _tax / 100 ;
        }

        public string GenerateInvoice()
        {
            string Invoice = "";
            Invoice = Invoice + "Id :" + Id + "\n";
            Invoice = Invoice + "Title :" + Title + "\n";
            Invoice = Invoice + "Amount :" + Amount + "\n";
            Invoice = Invoice + "Discount Percentage :" + DiscountPercent + "%" + "\n";
            Invoice = Invoice + "Tax :" + _tax + "%" + "\n";
            Invoice = Invoice + "Final Amount :" + CalculateFinalAmount() + "\n";
            Invoice = Invoice + "Discount Amount :" + CalculateDiscountedAmount() + "\n";
            Invoice = Invoice + "Tax Amount :" + CalculateTaxAmount() + "\n";
            return Invoice;

        }
        public void PrintInvoice()
        {
            string Invoice = GenerateInvoice();
            Console.WriteLine(Invoice);
        }
        public void WriteHtmlFile()
        {
            string middle = GenerateInvoice();
            string end = @"  </body>
                              </html> ";
            string start = @"<!DOCTYPE html>
                   <html>
                    <body>

                   <h1> Invoice </h1>";
            //    <p> My first paragraph.</p>";

            string path = @"D:\Swabhavtechlab\C#\Basic\SolidPrinciples\SRP_ViolationApp\SRP_ViolationApp\write.html";

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fs))
                {
                    streamWriter.Write(start + middle + end);

                }
            }

        }
        public int Id { get { return _id; } }
        public string Title { get { return _title; } }
        public double Amount { get { return _amount; } }
        public int DiscountPercent { get { return _discountPercent; } }

        public float Tax { get { return _tax; } }
    }
}

