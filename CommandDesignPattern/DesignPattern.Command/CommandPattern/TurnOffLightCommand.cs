namespace DesignPattern.Command.CommandPattern
{
    public class TurnOffLightCommand : ICommand
    {
        private Light _light;
        public TurnOffLightCommand(Light light) => _light = light;
        public void Execute() => _light.TurnOff();
        public void Undo() => _light.TurnOn();
    }
}
