using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MerTestForelasning1.Models;

namespace MerTestForelasning1.Controllers
{
    public class ForkortningarController : Controller
    {
        // GET: Forkortningar
        public ActionResult ForkortningarDetails()
        {
            return View(new ForkortningarModel {Id = 1, Abbreviation = "Abbr", Explanation = "Abbreviation"});
        }

        public ActionResult FullDetails()
        {
            var grymmaListan = new List<ForkortningarModel>
            {
                new ForkortningarModel {Id = 1, Abbreviation = "Abbr", Explanation = "Abbreviation"},
                new ForkortningarModel {Id = 2, Abbreviation = "RTFM", Explanation = "Read the fucking manual"},
                new ForkortningarModel {Id = 3, Abbreviation = " BRB", Explanation = "Be right back"}

            };
            return View(grymmaListan);
        }

        public ActionResult FullDetailsTest()
        {
            var grymmaListan = new List<ForkortningarModel>
            {
                new ForkortningarModel {Id = 1, Abbreviation = "Abbr", Explanation = "Abbreviation"},
                new ForkortningarModel {Id = 2, Abbreviation = "RTFM", Explanation = "Read the fucking manual"},
                new ForkortningarModel {Id = 3, Abbreviation = " BRB", Explanation = "Be right back"}

            };
            return View(grymmaListan);
        }
    }
}