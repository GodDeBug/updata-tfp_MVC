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
        public ActionResult MyTestView()
        {
            ViewBag.sp = "这是一个测试版本";
            return View();
        }
    }
}