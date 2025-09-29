namespace DesignPattern.Strategy.StrategyPattern
{
    public class YurtiçiKargo : IShippingStrategy
    {
        public void Ship(string package)
        {
            Console.WriteLine($"{package} Yurtiçi Kargo ile gönderildi 🚛");
        }
    }
}
