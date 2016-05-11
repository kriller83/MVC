using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MerTestForelasning1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Single förkortning",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Forkortningar", action = "ForkortningarDetails", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Beer", 
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Beer", action = "List", id = UrlParameter.Optional }
                );
        }
    }
}
