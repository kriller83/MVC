using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebbApplication.Models;

namespace AjaxWebbApplication.Controllers
{
    public class GrudgeController : Controller
    {
        // GET: Grudge
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _GrudgesForRabbit(int id)
        {
            List<Grudge> grudges = ((Rabbit) Session["Rabbit"]).Grudges;
            return PartialView(grudges);
        }

        public PartialViewResult _Create(int id)  //Detta visar vad som skapats
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _Create(Grudge model)  //Här skapar vi 
        {
            //Hämta från db, dvs från Session (fulkod)
            ((Rabbit)Session["Rabbit"]).Grudges.Add(model);
            return RedirectToAction(actionName: "_GrudgesForRabbit", routeValues: new {id = 9});
        }
    }
}