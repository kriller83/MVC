using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Xml;

namespace Forelasning1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Recipe",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Recipe", action = "FullDetails", id = UrlParameter.Optional}
                //Ändra till recipe och fulldetails
                );
            routes.MapRoute(
                name: "Beer", //ändra namn til något mer passande
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Beer", action = "List", id = UrlParameter.Optional}
                //Ändra till recipe och fulldetails
                );
            routes.MapRoute(
                name: "KungFu",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "KungFu", action = "FullDetails", id = UrlParameter.Optional}
                );
    }
    }
}
