using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DoAn_Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Cart_Checkout",
                url: "thanh-toan",
                defaults: new { controller = "Cart", action = "Checkout", id = UrlParameter.Optional },
                 namespaces: new string[] { "Do_An_KDCLPM.Controller" }
            );

            routes.MapRoute(
                name: "Cart_Index",
                url: "gio-hang",
                defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional },
                 namespaces: new string[] { "Do_An_KDCLPM.Controller" }
            );

            routes.MapRoute(
                name: "Search",
                url: "tim-kiem",
                defaults: new { controller = "Products", action = "Search", id = UrlParameter.Optional },
                 namespaces: new string[] { "Do_An_KDCLPM.Controller" }
            );

            routes.MapRoute(
                name: "Accounts_Logout",
                url: "dang-xuat",
                defaults: new { controller = "Account", action = "Logout", id = UrlParameter.Optional },
                 namespaces: new string[] { "Do_An_KDCLPM.Controller" }
            );

            routes.MapRoute(
                name: "Accounts_Index",
                url: "dang-nhap-dang-ki",
                defaults: new { controller = "Account", action = "Index", id = UrlParameter.Optional },
                 namespaces: new string[] { "Do_An_KDCLPM.Controller" }
            );

            routes.MapRoute(
                name: "Product_Detail",
                url: "chi-tiet/{alias}",
                defaults: new { controller = "Products", action = "Detail", id = UrlParameter.Optional },
                 namespaces: new string[] { "Do_An_KDCLPM.Controller" }
            );

            routes.MapRoute(
                name: "Product_Index",
                url: "{alias}",
                defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional },
                 namespaces: new string[] { "Do_An_KDCLPM.Controller" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                 namespaces: new string[] { "Do_An_KDCLPM.Controller" }
            );
        }
    }
}
