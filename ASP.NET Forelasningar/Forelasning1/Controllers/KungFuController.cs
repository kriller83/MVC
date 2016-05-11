using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Forelasning1.Models;

namespace Forelasning1.Controllers
{
    public class KungFuController : Controller
    {
        // GET: KungFu
        public ActionResult FullDetails()
        {
            var masters = new List<KungFuMasterModel>
            {
                new KungFuMasterModel {ID = 1, Name ="Keith Andersson", Age=67, KungFuStyle="Wing Sun", Level="Master of destruction" },
                new KungFuMasterModel {ID = 2, Name ="Calle Andersson", Age=47, KungFuStyle="Wing Moon", Level="Master" },
                new KungFuMasterModel {ID = 3, Name ="Ann-Britt Andersson", Age=37, KungFuStyle="Wing Sun", Level="Fist Master" }

            };
            return View(masters);
        }

        public ActionResult Stars()
        {
            return View();
        }

        public ActionResult StarsFromController()
        {
            return View();
        }      
    }
    public static class ExtensionMethods  //Ramsan public static public static this. Med Extensionmethods kommer vi åt våra metoder..
    {
        public static string RatingStars(this HtmlHelper helper, int numberOfStars)
        {
            StringBuilder oh = new StringBuilder();//effektivt när vi kantinerar text
            oh.Append("< span style = 'color: orange' >");

            for (int i = 0; i < numberOfStars; i++)
            {
                oh.Append("*");
            }
            oh.Append(("</span"));
            return oh.ToString();

            return "";
        }
    }
}