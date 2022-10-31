using System;
using System.IO;
using SRP_ViolationApp.Model;

namespace SRP_ViolationApp
{
    internal class PrintInvoice
    {

        Invoice invoice = new Invoice(1001, "Restaurant Bill", 1000, 5);
        WriteHtmlFile(invoice,);


        public static void WriteHtmlFile()
        {

            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fs))
                {
                    streamWriter.Write(GetInvoice());

                }
            }
        }
    }
}
