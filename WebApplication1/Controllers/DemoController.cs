using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return Content(Request.QueryString["name"]);
        }
       public ActionResult PostData()
        {
            return Content(Request.Form["loginname"]);
        }
    }
}