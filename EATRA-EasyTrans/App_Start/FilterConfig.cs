using System.Web;
using System.Web.Mvc;

namespace EATRA_EasyTrans
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
