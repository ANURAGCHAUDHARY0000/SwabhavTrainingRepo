using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is the index page of home controller";
        }


        public ActionResult Greet(string userName)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10);

            if(randomNumber > 5)
            {
                return Content("<h1>Hello from Greet function to user" + userName + "</h1>");
            }
            else 
                return HttpNotFound("Could not find greeting message");

        }
       
        public ActionResult Browse()
        {
            return View();
        }




    }
}