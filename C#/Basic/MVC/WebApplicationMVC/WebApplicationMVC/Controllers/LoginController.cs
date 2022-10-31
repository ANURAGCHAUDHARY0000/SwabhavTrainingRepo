using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult Index()
        {
            return View(new LoginIndex());
        }

        [HttpPost]
        public ActionResult Index(LoginIndex vm)
        {
            if (Validation(vm.UserName, vm.UserPassword) == true)
            {
                vm.Message = "Wrong credentials";
            }
            else
            {
                vm.Message = "Successfull Login";
            }
            return View(vm);
        }


        public bool Validation(string username, string password)
        {
            if (username != "anurag" || password != "anurag")
            {
                return true;
            }
            return false;
        }



    }
}