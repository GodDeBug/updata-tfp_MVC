using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tfp_MVC.Controllers
{
    public class MyTestController : Controller
    {
        // GET: MyTest
        public ActionResult Index()
        {
         //   ViewBag.sp = "这是我第一次吃德州扒鸡";
            return View();
        }
    }
}