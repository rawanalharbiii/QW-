using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Patient_Guide()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Patient_Rights()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Health_Education()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Things()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult telephone()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult wifi()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult smoking()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult visiting()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Health_EducationM()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}