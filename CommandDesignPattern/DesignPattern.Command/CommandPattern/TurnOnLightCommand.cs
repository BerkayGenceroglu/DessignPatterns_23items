namespace DesignPattern.Command.CommandPattern
{
    public class TurnOnLightCommand : ICommand
    {
        private Light _light;
        public TurnOnLightCommand(Light light) => _light = light;
        public void Execute() => _light.TurnOn();
        public void Undo() => _light.TurnOff();
    }
}
