namespace DesignPattern.Strategy.StrategyPattern
{
    public class CargoContext
    {
        private IShippingStrategy _shippingStrategy;

        public void SetStrategy(IShippingStrategy strategy)
        {
            _shippingStrategy = strategy;
        }

        public void SendPackage(string package)
        {
            if (_shippingStrategy == null)
            {
                Console.WriteLine("Lütfen bir kargo firması seçin!");
            }
            else
            {
                _shippingStrategy.Ship(package);
            }
        }
    }
}
