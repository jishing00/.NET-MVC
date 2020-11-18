using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult ShowForm()
        {
            return View();
        }
        // GET: Demo
        [HttpGet]
        public ActionResult Index(String name)
        {
            return Content(name);
        }
        //[HttpPost]
        //public ActionResult Login(String name,String pwd)
        //{
        //    if (name == "admin" && pwd == "123")
        //        return Content("ok");
        //    else
        //        return Content("no");
        //}
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.LoginViewModel model)
        {
            if (ModelState.IsValid) {
                if (model.Email == "admin" && model.Password == "123")
                    return View();
                else
                    ModelState.AddModelError("", "帳號密碼有誤");
                    return View(model); ;
            }
            ModelState.AddModelError("", "資料有誤");
            return View(model); ;
        }
    }
}