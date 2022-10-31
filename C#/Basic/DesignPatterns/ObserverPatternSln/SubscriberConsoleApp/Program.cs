using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Model;
using SubscriberConsoleApp.Subscribers;

namespace SubscriberConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "abc", 5000);
            acc1.AddSubscriber(new SmsBalanceChangeNotification());
            acc1.AddSubscriber(new EmailBalanceChangeNotification());
            // acc1.Withdrawl(4501);
            acc1.Deposit(1000);
            Console.ReadKey();
        }
    }
}
