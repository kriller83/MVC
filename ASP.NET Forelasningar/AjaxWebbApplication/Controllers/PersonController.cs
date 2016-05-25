using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebbApplication.Models;

namespace AjaxWebbApplication.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            //Skapar en person och returnerar den till vyn
            Person person = new Person()
            {
                ID = 2,
                Name = "Freddie",
                BirthDate = new DateTime(year: 1977, month: 01, day: 15)
            };
            return View(person);

        }

        public string HitMe()
        {
            return "Paow!! Punch!!! -";
        }
    }
}