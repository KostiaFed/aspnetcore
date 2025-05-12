using Microsoft.AspNetCore.Mvc;
using firstwebapp.Models;

namespace MyApp.Namespace
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
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

        [HttpGet]
        public IActionResult Message() => View();

        [HttpPost]
        public IActionResult Message(string userMessage)
        {
            ViewBag.Message = userMessage;
            return View();
        }
    }
}
