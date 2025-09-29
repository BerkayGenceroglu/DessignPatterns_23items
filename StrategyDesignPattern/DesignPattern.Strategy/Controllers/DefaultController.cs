using DesignPattern.Strategy.StrategyPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Strategy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            CargoContext cargo = new CargoContext();

            // Aras Kargo seçildi
            cargo.SetStrategy(new ArasKargo());
            cargo.SendPackage("Laptop");

            // Yurtiçi Kargo seçildi
            cargo.SetStrategy(new YurtiçiKargo());
            cargo.SendPackage("Telefon");

            // PTT Kargo seçildi
            cargo.SetStrategy(new PTTKargo());
            cargo.SendPackage("Kitap");
            return View();
        }
    }
}
