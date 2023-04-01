using Microsoft.AspNetCore.Mvc;

namespace WebApplicationclass28._03.Controllers
{
    public class UserController:Controller
    {
        public ViewResult Profile()
        { 
            return View();
        }
    }
}
