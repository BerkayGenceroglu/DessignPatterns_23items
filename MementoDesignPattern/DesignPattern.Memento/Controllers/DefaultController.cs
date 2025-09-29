using DesignPattern.Memento.MementoPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Memento.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var editor = new TextEditor();
            var history = new History();

            // İlk içerik
            editor.Content = "Merhaba Dünya!";
            history.Push(editor.Save()); // Kaydet
            Console.WriteLine("Şu anki içerik: " + editor.Content);

            // İçeriği değiştirdik
            editor.Content = "Design Patterns çalışıyorum.";
            history.Push(editor.Save()); // Kaydet
            Console.WriteLine("Şu anki içerik: " + editor.Content);

            // Undo (geri al)
            editor.Restore(history.Pop());
            Console.WriteLine("Geri alındı: " + editor.Content);

            // Undo (tekrar geri al)
            editor.Restore(history.Pop());
            Console.WriteLine("Geri alındı: " + editor.Content);
            return View();
        }
    }
}
