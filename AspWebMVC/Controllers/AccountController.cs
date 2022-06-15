using Microsoft.AspNetCore.Mvc;

namespace AspWebMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

    }
}
