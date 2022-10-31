using System;
using System.IO;
using System.Xml;
namespace FileReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ReadTextFile();
           ReadEntireXmlFile();
           ReadInnerElementOfXmlFile();
            ReadHtmlFile();
        }
       
        public static void ReadTextFile()
        {
            string path = @"D:\Swabhavtechlab\C#\Basic\OOPS\FileReader\FileReader\TextFileReader.txt";
            string data = File.ReadAllText(path);
            Console.WriteLine(data);
            Console.WriteLine();
        }

        //This method will print entire xml file
        public static void ReadEntireXmlFile()
        {
            string path = @"D:\Swabhavtechlab\C#\Basic\OOPS\FileReader\FileReader\XMLFileReader.xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);
            xdoc.Save(Console.Out);
            Console.WriteLine();
        }

        public static void ReadInnerElementOfXmlFile()
        {
            string path = @"D:\Swabhavtechlab\C#\Basic\OOPS\FileReader\FileReader\XMLFileReader.xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);

            XmlNodeList nodes = xdoc.SelectNodes("//Students/s");
            foreach(XmlNode node in nodes)
            {
                XmlNode name = node.SelectSingleNode("name");
                if(name != null)
                {
                    Console.WriteLine(name.InnerText);
                }

                XmlNode result = node.SelectSingleNode("result");
                if (result != null)
                {
                    Console.WriteLine(result.InnerText);
                }
            }
        }

        public static void ReadHtmlFile()
        {
            string path = @"D:\Swabhavtechlab\C#\Basic\OOPS\FileReader\FileReader\Read.html";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    //string data = reader.ReadToEnd();
                    string data = File.ReadAllText(path);
                    Console.WriteLine(data);
                  
                }
            }

        }

    }
}
