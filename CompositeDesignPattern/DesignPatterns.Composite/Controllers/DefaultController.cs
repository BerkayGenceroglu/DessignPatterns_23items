using DesignPatterns.Composite.CompositePattern;
using DesignPatterns.Composite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace DesignPatterns.Composite.Controllers
{
    //Component → Ortak arayüz

    //Leaf → Alt elemanı olmayan

    //Composite → Alt elemanları olan
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.Include(x =>x.Products).ToList();
            var values = Rekursive(categories, new Category() { CategoryName = "FirstCategory", CategoryID = 0 }, new ProductComposite(0,"FirstComposite"));
            ViewBag.values = values;
            //👉 Bu durumda “FirstComposite” isimli sahte bir kök koyuyoruz.
            //O, hepsini kapsayan bir çatı oluyor.
            //Elektronik, Mobilya, Kitap → onun altına ekleniyor.
            return View();
        }
        public ProductComposite Rekursive(List<Category> categories,Category firstCategory,ProductComposite firstComposite,ProductComposite leaf = null)
        {
            categories.Where(x => x.UpperCategoryID == firstCategory.CategoryID).ToList().ForEach(x =>
            {
                var productComposite = new ProductComposite(x.CategoryID, x.CategoryName);
                x.Products.ToList().ForEach(y =>
                {
                    productComposite.Add(new ProductComponent(y.ProductId, y.ProductName));
                });
                if (leaf !=null)
                {
                    leaf.Add(productComposite);
                }
                else
                {
                    firstComposite.Add(productComposite);
                }
                Rekursive(categories, x, firstComposite, productComposite);
            });
            return firstComposite;
        }
    }
}
