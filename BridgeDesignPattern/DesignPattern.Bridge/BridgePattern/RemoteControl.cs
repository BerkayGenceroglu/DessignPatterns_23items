namespace DesignPattern.Bridge.BridgePattern
{
    public abstract class RemoteControl
    {
        protected IDevice _device;

        protected RemoteControl(IDevice device)
        {
            _device = device;
        }
        public abstract string On();
        public abstract string Off();
    }
}
