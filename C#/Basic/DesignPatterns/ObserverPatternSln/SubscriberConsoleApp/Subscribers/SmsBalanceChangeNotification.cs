using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Common;
using PublisherLib.Model;

namespace SubscriberConsoleApp.Subscribers
{
    internal class SmsBalanceChangeNotification : INotificationBalanceChange
    {
        public void Notify(Account account)
        {
            Console.WriteLine("\nSMS Notification Send...");
            Console.WriteLine("Acc no : {0}\nName : {1}\nAcc Balance : {2} ", account.AccountNumber, account.Name, account.Balance);
        }
    }
}
