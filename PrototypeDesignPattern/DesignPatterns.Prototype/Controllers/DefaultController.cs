using DesignPatterns.Prototype.PrototypePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Prototype.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            Enemy orc = new Enemy("Orc", 100);
            orc.ShowInfo();

            // Klon 1
            Enemy clone1 = orc.Clone();
            clone1.Name = "Orc Klon #1"; // ismini değiştirdik
            clone1.ShowInfo();

            // Klon 2
            Enemy clone2 = orc.Clone();
            clone2.Health = 150; // can değerini değiştirdik
            clone2.ShowInfo();
            return View();
        }
    }
}
