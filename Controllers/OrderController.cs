using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(OrderModel order)
        {
            return RedirectToAction("OrderSuccess");
        }

        public IActionResult OrderSuccess()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = new ProductModel { Id = id, Name = "To Delete" };
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            return RedirectToAction("List");
        }

    }
}
