using Microsoft.AspNetCore.Mvc;

namespace TakeIt.Web.Controllers
{
    public class HomeController : TakeItControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}