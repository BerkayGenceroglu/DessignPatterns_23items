namespace DesignPattern.Strategy.StrategyPattern
{
    public class ArasKargo : IShippingStrategy
    {
        public void Ship(string package)
        {
            Console.WriteLine($"{package} Aras Kargo ile gönderildi 🚚");
        }
    }
}
