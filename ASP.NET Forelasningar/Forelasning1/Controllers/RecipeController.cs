using Forelasning1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forelasning1.Models;

namespace Forelasning1.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult FullDetails()  //byter ut index mot FullDetails
        {
            //Vi skapar ett recipe
            //Lägg till using! högst upp
            var recipe = new RecipeDetailsModel //Truck ctrl + . och lägg till using. 
            {
                Name = "Tigerkaka",
                Ingredients = "2 ägg, 2 dl socker, 3 dl vetemjöl, 1tsk bakpulver, 1 tsk vaniljsocker, 1msk kakao, 1/2 dl vatten, 150 g smör",
                CookingTime = 34,
                Instructions = "Baka den",
                Difficulty = 2
            };

            return View(recipe); //Skickar in den i modellen! (recipe)
        }
    }
}