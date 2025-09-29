using DesignPattern.Abstract.AbstractPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Abstract.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ModernFurnitureFactory modernFactory = new ModernFurnitureFactory();
            IChair ModernSandelyemiz = modernFactory.CreateChair();
            ITable ModernMasamız = modernFactory.CreateTable();

            OldFurnitureFactory oldFurnitureFactory = new OldFurnitureFactory();
            IChair OldSandalye = oldFurnitureFactory.CreateChair();
            ITable oldMasa = oldFurnitureFactory.CreateTable();

            ViewBag.ModernSandelyemiz = ModernSandelyemiz.ChairName();
            ViewBag.ModernMasamız = ModernMasamız.TableName();

            ViewBag.OldSandalye = OldSandalye.ChairName();
            ViewBag.OldMasa = oldMasa.TableName();
            return View();
        }
    }
}
