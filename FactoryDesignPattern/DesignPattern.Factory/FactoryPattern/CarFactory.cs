namespace DesignPattern.Factory.FactoryPattern
{
    public class CarFactory
    {
        public static ICar CreateCar(string cartype)
        {
            switch (cartype)
            {
                case "BMW": return new BMW();
                case "Toyota": return new Toyota();
                case "Nissan": return new Nissan();
                default:
                    throw new ArgumentException("Geçersiz araba tipi");
            }
        }
    }
}
