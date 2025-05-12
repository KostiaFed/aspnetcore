using Microsoft.AspNetCore.Mvc;

namespace firstwebapp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Greeting()
    {
      var hour = DateTime.Now.Hour;
      string greeting = hour < 12 ? "Добрий ранок" :
                      hour < 18 ? "Добрий день" : "Добрий вечір";

      ViewBag.Greeting = greeting;
      return View();
    }

    public IActionResult DateTimeNow() => View(DateTime.Now);
  }
}
