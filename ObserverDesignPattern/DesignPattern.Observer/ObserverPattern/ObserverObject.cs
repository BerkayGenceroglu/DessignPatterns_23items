using DesignPattern.Observer.DAL;
using System.Collections.Generic;

namespace DesignPattern.Observer.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observer;

        public ObserverObject()
        {
            _observer = new List<IObserver>();
            //Yani: “Abonelerimi tutacak kutuyu açtım, artık içine ekleme/çıkarma yapabilirim.”
        }
        public void RegisterObserver(IObserver observer)
        {
            _observer.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observer.Remove(observer);
        }
        public void NotifyObserver(AppUser user)
        {
            _observer.ForEach(x =>
            {
                x.CreateNewUser(user);
            });
        }
    }
}
