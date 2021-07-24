using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            //This is conventional and old way of creating custom routing . We have better way to set routiing with MVC 5. i.e. Attribute Routing.
            //routes.MapRoute(
            //    "MoviesByRelasedDate",
            //    "movies/released/{year}/{month}",
            //    new { controller = "Movies",  action = "ByReleasedDate"},
            //    new { year = @"\d{4}", month = @"\d{2}"});  ///Anonymous object to apply contraint to incoming parameter from browser url. (Here year must be of 4 digit and month must be of 2 digit.)

            //Enabling Attribute routing in our application.
            routes.MapMvcAttributeRoutes();


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
