using DesignPattern.Command.CommandPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Command.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            Light livingRoomLight = new Light();

            // Komut nesneleri
            ICommand lightOn = new TurnOnLightCommand(livingRoomLight);
            ICommand lightOff = new TurnOffLightCommand(livingRoomLight);

            // Invoker
            RemoteControl remote = new RemoteControl();

            // Açma komutu
            remote.SetCommand(lightOn);
            remote.PressButton();   // 👉 "Lamba açıldı 💡"
            remote.PressUndo();     // 👉 "Lamba kapandı 🌑"

            // Kapama komutu
            remote.SetCommand(lightOff);
            remote.PressButton();   // 👉 "Lamba kapandı 🌑"
            remote.PressUndo();     // 👉 "Lamba açıldı 💡"
            return View();
        }
    }
}
