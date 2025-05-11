using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace MyApp.Namespace
{
    [Authorize]
    public class AdminController : Controller
    {
        public IActionResult ManageUsers() => View();
        public IActionResult ManageProducts() => View();
        public IActionResult Dashboard() => View();
    }

}
