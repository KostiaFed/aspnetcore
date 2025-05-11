using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
