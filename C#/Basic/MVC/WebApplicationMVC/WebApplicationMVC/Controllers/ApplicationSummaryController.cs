using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplicationMVC.Controllers
{
    public class ApplicationSummaryController : Controller
    {
        // GET: ApplicationSummary
        public ActionResult Index()
        {
           return View();   
           
        }
    }
}