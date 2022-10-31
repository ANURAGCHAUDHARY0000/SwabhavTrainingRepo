using System;
using AuthDictioanaryApp.Service;


namespace AuthDictioanaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Service = new AuthenticationService();
            Console.WriteLine(Service.CheckValidUser(1,"1abc"));
            Console.WriteLine(Service.CheckValidUser(5,"5cde"));
            Console.WriteLine(Service.CheckValidUser(6,"ade"));
        }
    }
}
