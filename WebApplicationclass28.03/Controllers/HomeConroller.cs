using Microsoft.AspNetCore.Mvc;

namespace WebApplicationclass28._03.Controllers
{
    public class HomeController:Controller
    {
        public /*ViewResult*/ ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}
