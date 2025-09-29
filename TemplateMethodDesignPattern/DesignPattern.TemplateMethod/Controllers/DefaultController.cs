using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans basicPlan = new BasicPlan();
            return View(basicPlan);
        }
        public IActionResult PremiumIndex()
        {
            NetflixPlans PremiumPlan = new PremiumPlan();
            return View(PremiumPlan);
        }
    }
}
