using DesignPattern.Factory.FactoryPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Factory.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ICar car1 = CarFactory.CreateCar("BMW");
            var value =car1.Drive();
            var car2 = CarFactory.CreateCar("Nissan");
            var value2 = car2.Drive();
            ViewBag.Message = value;
            ViewBag.Message2 = value2;
            return View();
        }
    }
}
