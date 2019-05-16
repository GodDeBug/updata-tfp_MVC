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
            ViewBag.sp = "11111111111";
            return View();
        }
    }
}