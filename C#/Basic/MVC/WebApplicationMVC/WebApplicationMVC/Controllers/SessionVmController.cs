using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class SessionVmController : Controller
    {
        // GET: SessionVm
        public ActionResult Index()
        {
            IndexVM vm = new IndexVM();
            var counter = Session["counter"];
            if (Session["counter"] == null)
            {
                Session["counter"] = 0;
            }
            vm.OldValue = Session["counter"].ToString();
            Session["counter"] = (int)Session["counter"] + 1;
            vm.NewValue = Session["counter"].ToString();
            vm.SessionId = Session.SessionID.ToString();
            vm.Title = "This is strongly typed view";
            return View(vm);
        }
    }
}