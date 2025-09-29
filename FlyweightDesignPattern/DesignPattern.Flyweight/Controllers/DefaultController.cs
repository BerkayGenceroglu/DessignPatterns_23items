using DesignPattern.Flyweight.FlyweightPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Flyweight.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            CharacterFactory factory = new CharacterFactory();

            Character a1 = factory.GetCharacter('A', "Arial");
            a1.Display(12);

            Character a2 = factory.GetCharacter('A', "Arial");
            a2.Display(14);

            Character b1 = factory.GetCharacter('B', "Times New Roman");
            b1.Display(12);
            return View();
        }
    }
}
