using System;
using System.Configuration;

namespace AppConfigFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string configvalue1 = ConfigurationManager.AppSettings["connection1"];
            //string configvalue2 = ConfigurationManager.AppSettings["connection2"];
            //Console.WriteLine(configvalue1+" "+configvalue2);
            GetServerAndDatabaseName("connection1");
            GetServerAndDatabaseName("connection2");
          
        }
        public static void GetServerAndDatabaseName(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key] ;
           // Console.WriteLine(result);
            string[] s2 = result.Split(';');
            //foreach (string s in s2)
            //Console.WriteLine(s);
            string servername = s2[0];
            string databasename = s2[1];
            Console.WriteLine(servername);
            Console.WriteLine(databasename);
            Console.WriteLine();
        }

    }
}
