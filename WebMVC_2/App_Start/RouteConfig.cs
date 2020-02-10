using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebMVC_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "Sale/FormPost",
                defaults: new { controller = "Sale", action = "FormPost", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "r1",
                url: "",
                defaults: new { controller = "Sale", action = "ListDataAll", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "r2",
                url: "STEP/{Year}",
                defaults: new { controller = "Sale", action = "ListDataYear", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "r3",
                url: "STEP/{Year}/{Month}",
                defaults: new { controller = "Sale", action = "ListDataYearMonth", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "r4",
               url: "STEP/{Year}/{Month}/{Day}",
               defaults: new { controller = "Sale", action = "ListDataYearMonthDay", id = UrlParameter.Optional }
           );
        }
    }
}
