using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Permite la autorizacion de entity
            filters.Add(new AuthorizeAttribute());
            //Permite de manejo de api request
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
