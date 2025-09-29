using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{

    //Senin örnek özelinde
    //ObserverObject → Yayıncı. “Yeni kullanıcı geldiğinde herkese haber vereyim.”
    //CreateMagazineAnnouncement → Abone.Görevi: “Yeni kullanıcı gelince dergi duyurusu kaydı oluşturayım.”
    //📌 Burada “abone” kelimesi → sistemde olayı dinleyen servis/sınıf demek.
    //Yani CreateMagazineAnnouncement gerçek bir insan değil, senin kodunun içindeki bir iş servisi.
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _ıserviceprovider;

        public CreateDiscountCode(IServiceProvider ıserviceprovider)
        {
            _ıserviceprovider = ıserviceprovider;
        }
        Context _context = new Context();

        public void CreateNewUser(AppUser user)
        {
            _context.Discounts.Add(new Discount
            {
                DiscountCode = "WELCOME2026",
                DiscountAmount = 20,
                DiscountCodeStatus = true
            });
            _context.SaveChanges();
        }
    }
}
