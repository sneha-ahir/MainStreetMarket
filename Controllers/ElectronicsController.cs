using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Controllers
{
    public class ElectronicsController : Controller
    {
        // GET: Electronics
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Electronics()
        {
            return View();
        }
    }
}