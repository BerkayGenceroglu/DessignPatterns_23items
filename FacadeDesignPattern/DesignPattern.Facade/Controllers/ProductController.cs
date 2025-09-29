using DesignPattern.Facade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product Product)
        {
            context.Products.Add(Product);
            context.SaveChanges();
            return RedirectToAction(nameof(ProductController.ProductList));
        }

        public IActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = context.Products.Find(id);
            context.Products.Remove(value!);
            context.SaveChanges();
            return RedirectToAction(nameof(ProductController.ProductList));
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = context.Products.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product Product)
        {
            context.Products.Update(Product);
            context.SaveChanges();
            return RedirectToAction(nameof(ProductController.ProductList));
        }
    }
}
