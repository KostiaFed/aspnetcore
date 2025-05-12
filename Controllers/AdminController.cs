using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using firstwebapp.Models;

namespace MyApp.Namespace
{
  [Authorize]
  public class AdminController : Controller
  {
    public IActionResult ManageUsers() => View();
    public IActionResult ManageProducts() => View();
    public IActionResult Dashboard() => View();

    public IActionResult Index()
    {
        ViewBag.IsAdmin = User.IsInRole("Admin");
        return View();
    }

  }

}
