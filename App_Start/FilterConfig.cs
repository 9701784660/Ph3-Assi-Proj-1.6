using System.Web;
using System.Web.Mvc;

namespace _1._6_Various_Action_results
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
