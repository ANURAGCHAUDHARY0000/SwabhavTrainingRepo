using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplicationMVC.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
    
        public ActionResult Index()
        {

            if (Session["counter"] == null)
            {
                Session["counter"] = 0;
            }
            Session["counter"] = (int)Session["counter"] + 1;
            return View();
        }

    }




    }
