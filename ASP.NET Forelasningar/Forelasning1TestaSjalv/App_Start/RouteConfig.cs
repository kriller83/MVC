using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Forelasning1TestaSjalv
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Förkortningar",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Caramell", action = "CaramellDetails", id = UrlParameter.Optional }
            );
        }
    }
}
