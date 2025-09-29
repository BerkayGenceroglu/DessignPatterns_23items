using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover mover = new VisitRouteMover();
            List<string> citycountryInfo = new List<string>();
            mover.AddVisitRoute(new VisitRoute() { CountryName="İspanya",CityName="Madrid",VisitPlaceName="Madrid Meydanı"});
            mover.AddVisitRoute(new VisitRoute() { CountryName="İtalya",CityName="Roma",VisitPlaceName="Kutsal Melek Kalesi"});
            mover.AddVisitRoute(new VisitRoute() { CountryName="Almanya",CityName="Berlin",VisitPlaceName="Berlin Duvarı"});
            mover.AddVisitRoute(new VisitRoute() { CountryName="Fransa",CityName="Paris",VisitPlaceName="İtalya"});
            mover.AddVisitRoute(new VisitRoute() { CountryName="ABD",CityName="NewYork",VisitPlaceName="Times Meydanı"});

            var iterator = mover.CreateIterator();

            while (iterator.NextLocation())
            {
                citycountryInfo.Add("Ülke:" +iterator.CurrentItem.CountryName + "-- " + "Şehir:" +iterator.CurrentItem.CityName + "-- " + "Mekan:" +iterator.CurrentItem.VisitPlaceName);
            }
            ViewBag.citycountryInfo = citycountryInfo;
            return View();
        }
    }
}
