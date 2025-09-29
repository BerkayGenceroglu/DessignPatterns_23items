using DesignPattern.Adapter.AdapterPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Adapter.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            SquarePlug squarePlug = new SquarePlug();
            PlugAdapter adapter = new PlugAdapter(squarePlug);
            adapter.ConnectRound();
            return View();
        }
    }
}
//🔹 Çalışma Mantığı

//Müşteri (Client) yuvarlak fiş bekliyor.

//Bizim elimizde kare fiş var (SquarePlug).

//Adapter (PlugAdapter) araya giriyor → ConnectRound() çağrıldığında içeride ConnectSquare() çalışıyor.

//Sonuç: Sistem uyumlu çalışıyor.

//🔹 Özet

//Adapter: Uyumsuz arayüzleri birbirine uydurur.

//Amaç: Eski kodu değiştirmeden yeni sisteme entegre etmek.

//Günlük hayat: Priz adaptörü, HDMI–VGA dönüştürücü.

//Kod: Adapter sınıfı → yeni arayüzü uygular, ama içinde eski sınıfı