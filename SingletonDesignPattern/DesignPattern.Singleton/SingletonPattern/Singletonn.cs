namespace DesignPattern.Singleton.SingletonPattern
{
    public class Singletonn
    {
        // Tek örneği saklayacak alan
        private static Singletonn _instance;

        // Dprivate yaparak sınıfın dışarıdan newlenmesini engelliyoruz.
        private Singletonn() { }

        // Nesneye erişim sağlayan metot
        public static Singletonn GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singletonn(); // İlk kez oluşturuluyor
            }
            return _instance; // Hep aynı nesne dönüyor
        }

        public void ShowMessage()
        {
            Console.WriteLine("Merhaba! Ben tekil nesneyim :)");
        }
    }
}
