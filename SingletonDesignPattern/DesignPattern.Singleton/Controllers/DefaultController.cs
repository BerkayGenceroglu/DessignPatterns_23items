using Microsoft.AspNetCore.Mvc;
using DesignPattern.Singleton.SingletonPattern;

namespace DesignPattern.Singleton.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            Singletonn s1 = Singletonn.GetInstance();
            Singletonn s2 = Singletonn.GetInstance();

            s2.ShowMessage();
            s1.ShowMessage();

            Console.WriteLine(Object.ReferenceEquals(s1, s2)); // True
            return View();
        }
    }
}
