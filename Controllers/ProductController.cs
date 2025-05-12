using Microsoft.AspNetCore.Mvc;
using firstwebapp.Filters;
using firstwebapp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Namespace
{
  public class ProductController : Controller
  {
    private static List<Product> _products = new List<Product>
    {
      new Product { Id = 1, Name = "Ноутбук", Price = 10 },
      new Product { Id = 2, Name = "Телефон", Price = 15 },
      new Product { Id = 3, Name = "Планшет", Price = 20 },
      new Product { Id = 4, Name = "Портативний комп'ютер", Price = 12 },
      new Product { Id = 5, Name = "Телевізор", Price = 14 },
      new Product { Id = 6, Name = "Радіо", Price = 8 },
      new Product { Id = 7, Name = "Колонка", Price = 13 }
    };

    public IActionResult List()
    {
      return View(_products);
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

    public IActionResult Details(string name)
    {
      return View("Details", name);
    }

    [HttpGet("/products/search")]
    public IActionResult Search(string query)
    {
        var results = string.IsNullOrWhiteSpace(query)
            ? new List<Product>()
            : _products.Where(p => p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();

        ViewBag.Query = query;
        return View(results);
    }
  }
}
