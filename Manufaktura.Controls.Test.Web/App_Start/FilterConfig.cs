using System.Web;
using System.Web.Mvc;

namespace Manufaktura.Controls.Test.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
