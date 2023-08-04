using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Controllers
{
    public class MenController : Controller
    {
        // GET: Men
        public ActionResult Index()
        {
            ViewBag.Message = "Your Men category index page.";

            return View();
        }
        public ActionResult Men()
        {
            ViewBag.Message = "Your Men category page.";

            return View();
        }
    }
}