using System.Web;
using System.Web.Mvc;

namespace NCS.PaperGeneration.ApiService
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
