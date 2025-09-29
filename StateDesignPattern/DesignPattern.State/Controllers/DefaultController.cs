using DesignPattern.State.StatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.State.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context(new GreenState());

            // 6 kere state değişimi simüle ediyoruz
            for (int i = 0; i < 6; i++)
            {
                context.Request();
            }
            return View();
        }
    }
}
