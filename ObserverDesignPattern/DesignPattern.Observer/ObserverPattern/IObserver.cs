using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser user);
    }
}
//“Ben yeni kullanıcı olayını dinliyorum, bana haber verildiğinde şunu yapacağım” sözleşmesi.

//Yani her abone bu metodu yazmak zorunda.