using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPIOne
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //Exemplo de como configurar uma outra rota e expecifica pra uma controller
            /*config.Routes.MapHttpRoute(
                name: "ProdApi",
                routeTemplate: "api/prod/{id}",
                defaults: new { controller = "products", id = RouteParameter.Optional }
            );*/

            //Default Route
            /*config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );*/
        }
    }
}
