using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLabb1.Controllers
{
    public class LaserController : Controller
    {
        // GET: Laser
        public ActionResult Eye()
        {
            return View();
        }
        public ActionResult Pointer()
        {
            return View();
        }
        public ActionResult Printer()
        {
            return View();
        }
        public ActionResult Sabel()
        {
            return View();
        }
    }
}