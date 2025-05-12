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
      new Product { Id = 1, Name = "Ноутбук", Price = 10, Description = "Потужний ноутбук" },
      new Product { Id = 2, Name = "Телефон", Price = 15, Description = "Потужний телефон" },
      new Product { Id = 3, Name = "Планшет", Price = 20, Description = "Потужний планшет" },
      new Product { Id = 4, Name = "Портативний комп'ютер", Price = 12, Description = "Потужний комп" },
      new Product { Id = 5, Name = "Телевізор", Price = 14, Description = "Потужний телевізор" },
      new Product { Id = 6, Name = "Радіо", Price = 8, Description = "Потужне радіо" },
      new Product { Id = 7, Name = "Колонка", Price = 13, Description = "Потужна колонка" }
    };

    public IActionResult List()
    {
      return View(_products);
    }

    [HttpGet]
    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Product product)
    {
      if (ModelState.IsValid)
      {
        product.Id = _products.Max(p => p.Id) + 1;
        _products.Add(product);
        return RedirectToAction("List");
      }
      return View(product);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
      var product = _products.FirstOrDefault(p => p.Id == id);
      if (product == null) return NotFound();
      return View(product);
    }

    [HttpPost]
    public IActionResult Edit(Product product)
    {
      var existing = _products.FirstOrDefault(p => p.Id == product.Id);
      if (existing == null) return NotFound();

      existing.Name = product.Name;
      existing.Price = product.Price;
      existing.Description = product.Description;
      return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
      var product = _products.FirstOrDefault(p => p.Id == id);
      if (product == null) return NotFound();
      return View(product);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
      var product = _products.FirstOrDefault(p => p.Id == id);
      if (product != null) _products.Remove(product);
      return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
      var product = _products.FirstOrDefault(p => p.Id == id);
      if (product == null)
          return NotFound();

      return View(product);
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
