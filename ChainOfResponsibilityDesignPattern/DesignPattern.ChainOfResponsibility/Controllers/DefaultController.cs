using DesignPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAsistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();
            // Hepsi Employee türünden değişken olarak tanımlanıyor(çok biçimlilik – polymorphism sayesinde).
            //Ama gerçekte her biri farklı bir rol: Treasurer, ManagerAssistant, Manager, AreaDirector.
            treasurer.SetNextApprover(managerAsistant);
            managerAsistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(model);
            return View();
        }
        //Esnek olsun, zinciri kurarken herkesle ortak tip (Employee) üzerinden çalışabilelim diye employee türünde
        /*
         Bu satırda, treasurer nesnesi hala bir Treasurer olmasına rağmen, onu bir Employee olarak kullanabileceğimizi belirtiyoruz. Bu, bize şu esnekliği sağlar:

        Genelleme: Farklı türdeki çalışanları (Mühendis, Muhasebeci, Veznedar) aynı Employee listesinde tutabiliriz.

        Esneklik: Employee sınıfında tanımlı olan, tüm çalışanlar için ortak metotları (örneğin, maaşHesapla()) bu nesneler üzerinde tek bir şekilde çağırabiliriz.
         Treasurer treasurer = new Treasurer(); spesifik bir nesne oluşturur ve onu sadece kendi türünde kullanır. Employee treasurer = new Treasurer(); ise aynı nesneyi daha genel ve esnek bir şekilde kullanmamızı sağlar.

        Tam da dediğin gibi, Employee treasurer = new Treasurer(); satırı, polimorfizm (çok biçimlilik) ilkesi sayesinde çalışıyor.

        Kısaca:
        Treasurer sınıfı, Employee sınıfını miras aldığı için bir Employee'dir.
        Bu sayede, daha özel olan Treasurer nesnesini, daha genel olan Employee türünde bir değişkenin içinde saklayabiliyoruz.
        Bu zincirleme (yani Treasurer'ın bir Employee olması), bize genel bir türle (Employee) işlem yapma esnekliği sağlar. Böylece, kodumuzda her özel durum için ayrı bir kod yazmak yerine, tüm çalışanlar için ortak olan Employee sınıfını kullanabiliriz.
        --------------
        Treasurer treasurer = new Treasurer(); yazarsan → sadece Treasurer olarak kullanabilirsin.
        Ama Employee treasurer = new Treasurer(); yazarsan → üst sınıf tipi (Employee) üzerinden kullanıyorsun.
        👉 Bu sayede:
        Hepsini aynı tür (Employee) altında toplayabiliyoruz.
        Zinciri kurarken (SetNextApprover(Employee nextApprover)) sorun yaşamıyoruz.
        Ama arkada nesne hala Treasurer. Çalıştırınca kendi ProcessRequest metodunu çalıştırıyor.
        📌 İşte bu olayın adı Polymorphism (Çok Biçimlilik).
        “Bir alt sınıf nesnesini, üst sınıf tipiyle kullanabilmek.”
         */
    }
}
