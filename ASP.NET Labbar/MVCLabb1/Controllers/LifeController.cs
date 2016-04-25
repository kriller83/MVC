using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLabb1.Controllers
{
    public class LifeController : Controller
    {
        // GET: Life
        public ActionResult Health()
        {
            return View();
        }
        public ActionResult Live(int? id)
        {
            if (id != null)
            {
                ViewBag.Amount = id;
            }
            else
            {
                ViewBag.Amount = "";
            }
            return View();

        }
        public ActionResult SuperMario()
        {
           
            return View();
        }
    }
}