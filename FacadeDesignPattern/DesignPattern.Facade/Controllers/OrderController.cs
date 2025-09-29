using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();
        OrderFacade orderFacade = new OrderFacade();

        [HttpGet]
        public IActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrder(int customerId, int productId, int productCount, decimal productUnitPrice)
        {
            
            orderFacade.CompleteOrder(customerId,productId, productCount, productUnitPrice);
            return View();
        }
    }
}
