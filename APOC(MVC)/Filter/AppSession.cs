using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APOC_MVC_.Filter
{
    public class AppSession: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["My_user"] == null)
            {
                HttpContext.Current.Response.Redirect("/Login");

            }
        }
    }
}