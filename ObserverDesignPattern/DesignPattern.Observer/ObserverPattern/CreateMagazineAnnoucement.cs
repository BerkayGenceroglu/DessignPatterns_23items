using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{

    //Senin örnek özelinde
    //ObserverObject → Yayıncı. “Yeni kullanıcı geldiğinde herkese haber vereyim.”
    //CreateMagazineAnnouncement → Abone.Görevi: “Yeni kullanıcı gelince dergi duyurusu kaydı oluşturayım.”
    //📌 Burada “abone” kelimesi → sistemde olayı dinleyen servis/sınıf demek.
    //Yani CreateMagazineAnnouncement gerçek bir insan değil, senin kodunun içindeki bir iş servisi.
    public class CreateMagazineAnnoucement : IObserver
    {

        private readonly IServiceProvider _ıserviceprovider;

        public CreateMagazineAnnoucement(IServiceProvider ıserviceprovider)
        {
            _ıserviceprovider = ıserviceprovider;
        }
        Context _context = new Context();
        public void CreateNewUser(AppUser user)
        {
            _context.UserProcesses.Add(new UserProcess()
            {
                Magazine = "Bilim Dergisi",
                NameSurname = user.Name + " " + user.Surname,
                Content = $"Değerli {user.Name} {user.Surname} Bilim Dergisi'ne abone olduğunuz için teşekkür ederiz. İlk sayımızı en kısa sürede size ulaştıracağız."
            });
            _context.SaveChanges();
        }
    }
}
