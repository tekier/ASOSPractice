using System.Net.Http.Headers;
using System.Web.Http;

namespace CoffeeManager.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional}
            );
            
            config.Routes.MapHttpRoute(
                name: "TawqirsApi",
                routeTemplate: "{controller}/{id}",
                defaults: new {controller="Home",id = RouteParameter.Optional}
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
