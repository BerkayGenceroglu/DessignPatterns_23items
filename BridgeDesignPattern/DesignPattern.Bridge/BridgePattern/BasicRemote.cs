using DesignPattern.Bridge.BridgePattern;

namespace DesignPattern.Bridge.BridgePattern
{
    public class BasicRemote : RemoteControl
    {
        public BasicRemote(IDevice device) : base(device)
        {
        }

        public override string Off()
        {
           return  _device.TurnOff();
        }

        public override string On()
        {
           return  _device.TurnOn();
        }
        //Kumandanın görevi: Aç/Kapat.

        //Ama hangi cihazı açtığını bilmez.

        //_device referansı üzerinden köprü kurar.
    }
}
//Normal Senaryoda Ne Olurdu?

//Diyelim ki RemoteControl sınıfı TV’ye sabit bağlı olsaydı:

//public class RemoteControl
//{
//    private TV _tv;

//    public RemoteControl()
//    {
//        _tv = new TV();
//    }

//    public void On() => _tv.TurnOn();
//    public void Off() => _tv.TurnOff();
//}


//👉 Burada kumanda sadece TV için çalışır.
//Yarın Radyo eklersen RemoteControl’u yeniden yazman gerekir.

//🔹 Bridge’de Ne Oluyor?

//Şu satır:

//protected IDevice _device;


//Kumanda artık TV’ye sabit bağlı değil.

//RemoteControl sadece bir IDevice referansı tutuyor.