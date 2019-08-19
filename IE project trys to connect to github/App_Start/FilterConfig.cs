using System.Web;
using System.Web.Mvc;

namespace IE_project_trys_to_connect_to_github
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
