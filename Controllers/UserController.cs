using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserModel user)
        {
            return RedirectToAction("Details", user);
        }

        public IActionResult Details(UserModel user)
        {
            return View(user);
        }
    }
}
