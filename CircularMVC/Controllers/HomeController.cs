using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CircularMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult StartAction()
        {
            return View();
        }
    }
}