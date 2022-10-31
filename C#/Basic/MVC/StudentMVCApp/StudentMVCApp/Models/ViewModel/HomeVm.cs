using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMVCApp.Models.ViewModel
{
    public class HomeVm
    {

        public List<Student> Students { get; set; }
        public int StudentCount { get; set; }

    }
}