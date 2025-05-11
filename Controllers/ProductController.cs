using Microsoft.AspNetCore.Mvc;
using firstwebapp.Filters;

namespace MyApp.Namespace
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            var products = new List<string> { "Laptop", "Phone", "Tablet" };
            return View(products);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = new ProductModel { Id = id, Name = "Laptop" };
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(ProductModel product)
        {
            return RedirectToAction("List");
        }

    }
}
