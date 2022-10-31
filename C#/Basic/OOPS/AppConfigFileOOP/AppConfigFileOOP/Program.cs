using System;
using AppConfigFileOOP.Model;

namespace AppConfigFileOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           AppConfig appConfig = new AppConfig();   
           appConfig.GetServerName("connection1");
           appConfig.GetDataBaseName("connection1");
           appConfig.GetServerName("connection2");
           appConfig.GetDataBaseName("connection2");
          
        }
    }
}
