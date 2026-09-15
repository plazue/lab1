using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace phat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult vnexpress()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult product()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult BT2_Lab01b()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult BT3_Lab01b()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult tabble()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}