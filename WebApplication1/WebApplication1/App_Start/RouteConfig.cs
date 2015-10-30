using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
            routes.MapRoute(
                name: "Index",
                url: "Index",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
               name: "Image",
               url: "Image",
               defaults: new { controller = "Home", action = "Image", id = UrlParameter.Optional }
           );


            routes.MapRoute(
              name: "Music",
              url: "Music",
              defaults: new { controller = "Home", action = "Music", id = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "History",
              url: "History",
              defaults: new { controller = "Home", action = "History", id = UrlParameter.Optional }
          );
         

             routes.MapRoute(
             name: "olol",
             url: "",
             defaults: new { controller = "Home", action = "History", id = UrlParameter.Optional }
         );
            routes.MapRoute(
                name: "Index",
                url: "Index",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
               name: "Image",
               url: "Image",
               defaults: new { controller = "Home", action = "Image", id = UrlParameter.Optional }
           );


            routes.MapRoute(
              name: "Music",
              url: "Music",
              defaults: new { controller = "Home", action = "Music", id = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "History",
              url: "History",
              defaults: new { controller = "Home", action = "History", id = UrlParameter.Optional }
          );

        }
    }
}
