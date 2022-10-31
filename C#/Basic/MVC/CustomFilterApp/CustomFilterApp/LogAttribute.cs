using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomFilterApp
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        //Mvc supoorts 
        //Authorization Filter : override OnAuthorization()

        //Action Filter : override OnActionExecuting() & OnAction()

        //Result Filter : overide OnResultExecuting()  & OnResultExecuted()

        //Exception Filter : 
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Trace("OnActionExecuting", filterContext.RouteData);

        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Trace("OnResultExecuting", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Trace("OnResultExecuted", filterContext.RouteData);
        }

        private void Trace(string methodName, System.Web.Routing.RouteData routeData)
        {
            string controllerName = routeData.Values["controller"].ToString();
            string actionMethodName = routeData.Values["action"].ToString();
            HttpContext.Current.Response.Write($"MethodName = {methodName}, Controller = {controllerName}, Action = {actionMethodName} <br><br>");
        }

    }
}