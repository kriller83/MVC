using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forelasning1.Models;

namespace Forelasning1.Controllers
{
    public class BeerController : Controller
    {
        // GET: Beer
        public ActionResult List()
        {
            return View(beers); //Här kan man lägga in i databas om vi haft någon..Men nu lägger vi in beers. 
        }

        //Gör en modell som returnerar en lista på öl (gör en lista)
        private static List<BeerDetailsModel> beers = new List<BeerDetailsModel>
        {
            new BeerDetailsModel {ID = 1, Name = "Eric", Description = "Soft and smooth", AlcoholVolume = 3.5M},
            new BeerDetailsModel {ID = 1, Name = "Mariestad", Description = "Smoky", AlcoholVolume = 4.5M},
            new BeerDetailsModel {ID = 1, Name = "Carlsberg", Description = "Watery", AlcoholVolume = 2.5M},
            new BeerDetailsModel {ID = 1, Name = "Sofieberg", Description = "Tasty", AlcoholVolume = 3.5M},
        };
    }
}