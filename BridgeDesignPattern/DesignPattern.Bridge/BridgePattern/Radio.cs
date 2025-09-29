namespace DesignPattern.Bridge.BridgePattern
{
    public class Radio : IDevice
    {
        public string TurnOff()
        {
            return "Radyo Kapatıldı";
        }

        public string TurnOn()
        {
            return "Radyo Açıldı";
        }
    }
}
