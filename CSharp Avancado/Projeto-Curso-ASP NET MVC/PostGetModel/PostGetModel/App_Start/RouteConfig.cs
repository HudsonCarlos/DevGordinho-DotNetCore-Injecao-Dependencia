using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PostGetModel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(name: "Todas as Noticias", url: "noticias/", defaults: new { Controller = "Home", Action = "TodasAsNoticias" });

            routes.MapRoute(name: "Categoria Especifica", url: "noticias/{categoria}", defaults: new { Controller = "Home", Action = "MostraCategoria" });

            routes.MapRoute(name: "Mostra Noticia", url: "noticias/{categoria}/{titulo}-{noticiaId}", defaults: new { Controller = "Home", Action = "Mostranoticia", Id = @"\d+" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "PostGetModel.Controllers" }
            );
        }
    }
}
