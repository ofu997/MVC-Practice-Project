using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VideoApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            /*
            
            // make a custom route 
            // **custom route**
            routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new { controller = "Movies", action = "ByReleaseDate" },
                // constraining ranges for year and month
                // new {year= @"2000|2017", month=@"01|12"})
                // regular expression of 4 or characters
                new { year = @"\d{4}", month=@"\d{2}" });

            */

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
