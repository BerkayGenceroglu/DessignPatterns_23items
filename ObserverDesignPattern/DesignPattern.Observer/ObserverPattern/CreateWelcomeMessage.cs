using DesignPattern.Observer.DAL;
using System;
using System.Security.Policy;

namespace DesignPattern.Observer.ObserverPattern
{
    //Senin örnek özelinde
    //ObserverObject → Yayıncı. “Yeni kullanıcı geldiğinde herkese haber vereyim.”
    //CreateMagazineAnnouncement → Abone.Görevi: “Yeni kullanıcı gelince dergi duyurusu kaydı oluşturayım.”
    //📌 Burada “abone” kelimesi → sistemde olayı dinleyen servis/sınıf demek.
    //Yani CreateMagazineAnnouncement gerçek bir insan değil, senin kodunun içindeki bir iş servisi.
    public class CreateWelcomeMessage : IObserver
    {
        //Yani ServiceProvider = servis kutusu 🔑
        //IServiceProvider = alet çantası.
        private readonly IServiceProvider _serviceprovider;

        public CreateWelcomeMessage(IServiceProvider ıserviceprovider)
        {
            _serviceprovider = ıserviceprovider;
        }
        Context _context = new Context();
        public void CreateNewUser(AppUser user)
        {
            _context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = user.Name + " " + user.Surname,
                Content = $"Değerli {user.Name} {user.Surname} Sitemize hoşgeldiniz. Keyifli vakit geçirmenizi dileriz."
            });
            _context.SaveChanges(); 
        }
    }
}
//📌 GetService<T>()
//İstediğin servisi kutudan alır.
//Eğer servis kayıtlı değilse → null döner.
//Yani hata fırlatmaz, sessizce boş döner.
//➡ Günlük hayat: Arkadaşına “Kalemin var mı?” diye sorarsın. Yoksa “yok” der, olay kapanır.
//📌 GetRequiredService<T>()
//İstediğin servisi kutudan alır.
//Eğer servis kayıtlı değilse → InvalidOperationException (hata) fırlatır.
//Yani “Böyle bir servis kesin olmalı, yoksa uygulamayı patlat.” der.
//➡ Günlük hayat: Sınavda gözetmene “Kalemim yok, bana kalem vermek zorundasın!” dersin. Eğer vermezse sınavı yapamazsın = olay patl
