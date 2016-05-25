using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebbApplication.Models;

namespace AjaxWebbApplication.Controllers
{
    public class RabbitController : Controller
    {
        // GET: Rabbit
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            Rabbit rabbit = new Rabbit()
            {
                ID = 666,
                BirthDate = new DateTime(year: 2006, month: 06, day: 06),
                AngerLevel = 6,
                Name = "Puff Bunny",
                Grudges = new List<Grudge>()
                {
                    new Grudge() {ID = 7, TargetName = "Innocent Rabbits", Reason = "ADHD"},
                    new Grudge() {ID = 8, TargetName = "People", Reason = "Snitch"},
                }

            };
                           //Spara till DB... osv... vi gör fultrick.. Session..
               Session["Rabbit"] = rabbit;
            return View(rabbit);

        }
    }
}