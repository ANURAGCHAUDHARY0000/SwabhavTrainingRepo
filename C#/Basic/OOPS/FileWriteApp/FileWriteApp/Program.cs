using System;
using System.IO;
using System.Xml;

namespace FileReadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteHtmlFile();
            WriteTextFile();
            WriteXmlFile();
        }

        // method for write into html file
        public static void WriteHtmlFile()
        {
            String name = "Anurag";
            String address = "Van Vibhag Ghazipur";
            String path = @"D:\Swabhavtechlab\C#\Basic\OOPS\FileWriteApp\FileWriteApp\Write.html";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fs))
                {
                    streamWriter.Write(name);
                    streamWriter.Write(address);

                }

            }
        }

        //method for write into text file
        public static void WriteTextFile()
        {
            String path = @"D:\Swabhavtechlab\C#\Basic\OOPS\FileWriteApp\FileWriteApp\Write.txt";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fs))
                {
                    streamWriter.Write("krishna loves everyone");

                }

            }

        }

        // method for write into xml files
        public static void WriteXmlFile()
        {
            String path = @"D:\Swabhavtechlab\C#\Basic\OOPS\FileWriteApp\FileWriteApp\Write.xml";
            XmlTextWriter xmlwriter = new XmlTextWriter(path, System.Text.Encoding.UTF8);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.WriteStartDocument();
            xmlwriter.WriteStartElement("Students");

            for (int i = 1; i <= 2; i++)
            {
                xmlwriter.WriteStartElement("Student");

                Console.WriteLine("Enter the ID of Sttudent " + i);
                xmlwriter.WriteElementString("Id", Console.ReadLine());

                Console.WriteLine("Enter the Name of Sttudent " + i);
                xmlwriter.WriteElementString("Name", Console.ReadLine());

                Console.WriteLine("Enter the Class of Sttudent " + i);
                xmlwriter.WriteElementString("Class", Console.ReadLine());

                xmlwriter.WriteEndElement();
            }

            xmlwriter.WriteEndElement();
            xmlwriter.WriteEndDocument();
            xmlwriter.Flush();
            xmlwriter.Close();

        }
    }
}


