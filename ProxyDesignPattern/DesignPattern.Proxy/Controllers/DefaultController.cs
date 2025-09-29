using DesignPattern.Proxy.ProxyPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Proxy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            IImage image = new ProxyImage("profil.jpg");

            // Resim henüz yüklenmedi
            Console.WriteLine("Proxy oluşturuldu ama resim yüklenmedi.");

            // İlk display → resim diskten yüklenir
            image.Display();

            // İkinci display → diskten tekrar yüklenmez
            image.Display();
            return View();
        }
    }
}
