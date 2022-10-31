using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Model;

namespace PublisherLib.Common
{
    public interface INotificationBalanceChange
    {
        void Notify(Account account);
    }
}
