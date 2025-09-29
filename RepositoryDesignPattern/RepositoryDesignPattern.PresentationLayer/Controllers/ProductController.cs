using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;

namespace RepositoryDesignPattern.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productservice;

        public ProductController(IProductService productservice)
        {
            _productservice = productservice;
        }

        public IActionResult Index()
        {
            var values = _productservice.TCategoryName();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productservice.TInsert(product);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = _productservice.TGetById(id);
            _productservice.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = _productservice.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productservice.TUpdate(product);
            return RedirectToAction("Index");
        }
    }
}
