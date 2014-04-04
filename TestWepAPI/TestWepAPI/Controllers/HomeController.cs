using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWepAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public string ChrisFunc()
        {
            return "Chris is awesome!";
        }
		public ActionResult AboutFrank()
        {
            return View();
        }
    }
}
