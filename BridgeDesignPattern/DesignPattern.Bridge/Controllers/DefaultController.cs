using DesignPattern.Bridge.BridgePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Bridge.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            BasicRemote tvRemote = new BasicRemote(new TV());
            ViewBag.value = tvRemote.On();
            ViewBag.value2 = tvRemote.Off();

            BasicRemote radioRemote = new BasicRemote(new Radio());
            ViewBag.value3 = radioRemote.On();
            ViewBag.value4 = radioRemote.Off();
            return View();
        }
    }
}
