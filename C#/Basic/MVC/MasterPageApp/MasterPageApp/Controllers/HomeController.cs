using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterPageApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Home()
        {
            return View();
        }


        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Service()
        {
            return View();
        }

        public ActionResult Career()
        {
            return View();
        }

    }
}