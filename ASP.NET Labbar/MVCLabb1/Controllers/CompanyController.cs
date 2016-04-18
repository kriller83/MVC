using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLabb1.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult EcUtbildning()
        {
            return View();
        }
        public ActionResult Ericsson()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Volvo()
        {
            return View();
        }
    }
}