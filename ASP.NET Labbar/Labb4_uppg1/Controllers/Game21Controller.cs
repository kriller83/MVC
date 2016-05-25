using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb4_uppg1.Models;

namespace Labb4_uppg1.Controllers
{
    public class Game21Controller : Controller
    {
        // GET: Game21
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Play()
        {
            Game21.CurentValue = 0;
            Game21.Message = "Play";
            return View();
        }

        public PartialViewResult AddValue(int buttonValue)
        {
            var game = Game21.GetCurrentValue(buttonValue);
            return PartialView("_GamePV", model: game);
        }
    }
}