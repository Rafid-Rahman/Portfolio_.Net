using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "Educational Qualifications Information.";

            return View();
        }

        public ActionResult Project()
        {
            ViewBag.Message = "Projects listed below!";

            return View();
        }

        public ActionResult Reference()
        {
            ViewBag.Message = "Reference list!";

            return View();
        }

        public ActionResult Personal_info()
        {
            ViewBag.Message = "Here is my personal information provided!";

            return View();
        }
    }
}