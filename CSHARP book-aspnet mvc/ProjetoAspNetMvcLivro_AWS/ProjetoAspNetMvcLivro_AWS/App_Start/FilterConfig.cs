using System.Web;
using System.Web.Mvc;

namespace ProjetoAspNetMvcLivro_AWS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
