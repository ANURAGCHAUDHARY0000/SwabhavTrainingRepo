using System;
using System.Configuration;
namespace AppConfigFileOOP.Model
{
    internal class AppConfig
    {
        public  void GetServerName(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key];
            string[] s2 = result.Split(';');
            string servername = s2[0];
            Console.WriteLine(servername);
        }
        public  void GetDataBaseName(string key)
        {
            var appsettings = ConfigurationManager.AppSettings;
            string result = appsettings[key];
            string[] s3 = result.Split(';');
            string dataBaseName = s3[1];
            Console.WriteLine(dataBaseName);
            Console.WriteLine();
        }

      
    }
}
