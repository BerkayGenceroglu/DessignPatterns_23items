namespace DesignPattern.Bridge.BridgePattern
{
    public class TV : IDevice
    {
        public string TurnOff()
        {
            return "Televizyon Kapatıldı";
        }

        public string TurnOn()
        {
            return "Televizyon Açıldı";
        }
    }
}
