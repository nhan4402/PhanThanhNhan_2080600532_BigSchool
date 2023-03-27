using System.Web;
using System.Web.Mvc;

namespace PhanThanhNhan_2080600532
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
