using DesignPattern.Decarator.DAL;
using DesignPattern.Decorator.DecoratorPattern2;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Decorator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            Message message = new Message();
            message.MessageContent= "Merhaba";
            message.MessageSubject = "Konu";
            message.MessageSender = "Sender";
            message.MessageReceiver = "Receiver";

            CreateNewMessage createNewMessage = new CreateNewMessage();
            createNewMessage.CreateMessage(message);
            return View();
        }

        public IActionResult Index2()
        {
            Message message = new Message();
            message.MessageContent = "Toplantı 11 Geç Kalmayın";
            message.MessageSubject = "Toplantı";
            message.MessageSender = "Berkay";
            message.MessageReceiver = "Ekip";
            EncryptoSubjectDecorator encryptoSubjectDecorator = new EncryptoSubjectDecorator(new CreateNewMessage());
            encryptoSubjectDecorator.EncryptoSubjectCreateMessage(message);
            return View();
        }

        public IActionResult Index3()
        {
            Message message = new Message();
            message.MessageSender = "Yazılım Müdürü";
            message.MessageReceiver = "Herkes";
            message.MessageContent = "Genceroğlu Şirket";
            message.MessageSubject = "3";
            SubjectIDDecorator subjectIDDecorator = new SubjectIDDecorator(new CreateNewMessage());
            subjectIDDecorator.SubjectIdSendMessage(message);
            return View();
        }
    }
}
