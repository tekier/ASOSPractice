using System.Web.Mvc;
using System.Web.Routing;

namespace CustomerOrdersUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Hello",
                "{controller}/{action}/{name}/{age}",
                new { controller="HelloWorld", action="Welcome",name="",age=""}
            );

            routes.MapRoute(
                "Customer",
                "Customers/{action}/{custId}",
                new {controller="Customers", action = "GetFullCustomerDetails", custId=""}
            );
        }
    }
}
