using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forelasning1TestaSjalv.Models;

namespace Forelasning1TestaSjalv.Controllers
{
    public class CaramellController : Controller
    {
        // GET: Caramell
        public ActionResult CaramellDetails()
        {
            var caramells = new CaramellDetailsModel()
            {
                CaramellName = "Lakritsskalle",
                Color = "Black/Red",
                Flavor = "Sweet & Sour",
                Amount = 10
            };
                      
            return View(caramells);
        }
    }
}