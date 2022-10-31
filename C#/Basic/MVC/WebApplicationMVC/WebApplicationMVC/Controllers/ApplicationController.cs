using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {
            var vm = new ApplicationIndex();
            if (this.HttpContext.Application["Counter"] == null)
            {

                HttpContext.Application["Counter"] = 0;

            }
            vm.OldValue = (int)HttpContext.Application["Counter"];

            HttpContext.Application["Counter"] = (int)HttpContext.Application["Counter"] + 1;

            vm.NewValue = (int)HttpContext.Application["Counter"];

            return View(vm);
        }
    }
}