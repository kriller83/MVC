using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebbApplication.Models;

namespace AjaxWebbApplication.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _Create(int id)
        {
            Car car = new Car {PersonId = id};
            return PartialView(viewName:"_Create", model: car);
        }
        public void _HideCreate() {; }




        public PartialViewResult _Create2(int id)
        {
            Car car = new Car { PersonId = id };
            return PartialView(viewName: "_Create2", model: car);   //Skapar en vy utifrån create2. väljer create i nästa steg när vi lägger till en view. 
        }

        [HttpPost]
        public string _Create2(int id, Car model)
        {
            return "A car was successfully created";
        }
    }
}