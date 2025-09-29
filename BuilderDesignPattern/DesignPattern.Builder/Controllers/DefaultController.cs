using DesignPattern.Builder.BuilderPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Builder.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var director = new BurgerDirector(new KasapBurgerBuilder());
            director.CreateBurger(); 
            var burger = director; //director.GetBurger();
            return View();
        }
    }
}
