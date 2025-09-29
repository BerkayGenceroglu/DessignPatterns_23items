namespace DesignPattern.Strategy.StrategyPattern
{
    public class PTTKargo : IShippingStrategy
    {
        public void Ship(string package)
        {
            Console.WriteLine($"{package} PTT Kargo ile gönderildi 📦");
        }
    }
}
