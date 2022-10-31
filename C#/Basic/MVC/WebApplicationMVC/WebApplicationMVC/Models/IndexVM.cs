using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class IndexVM
    {
        public string Title { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string SessionId { get; set; }

    }
}