using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //一般存放不主要的資料
            ViewBag.Content = "這是CONTROLLER的數據";
            ViewBag.Name = "張三";
            ViewBag.Age = 22;
            ViewData["Age"] = 40; 

            return View();
        }
        public ActionResult PostData()
        {
            return Content(Request.Form["loginname"]);
        }
        public ActionResult FileData()
        {
            //SaveAs需要物理路徑
            Request.Files["file"].SaveAs(Request.MapPath("~/Uploads/" + Request.Files["file"].FileName));
            return Content("ok");
        }
        public ActionResult ResponseData()
        {
            //Response.Redirect("http://www.google.com");//重新請求路徑
            // Response.Write("hello world");//向C端輸出
            Response.Redirect("http://www.google.com");
            return Content("");
        }
        public ActionResult RequestHeader()
        {
            return Content(Request.Headers["token"]);
        }
        public void Demo() 
        {
            TempData["Data"] = "hello";
            Response.Redirect("~/Home/Demo2");
        }
        public ActionResult Demo2()
        {
            return View();
        }
        public ActionResult ShowData()
        {
            return View("Showdata2",new Student()
            {
                Id = 1,
                Name = "張三",
                Age = 18

            });
        }

    }
}