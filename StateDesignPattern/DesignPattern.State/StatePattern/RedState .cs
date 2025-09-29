namespace DesignPattern.State.StatePattern
{
    public class RedState : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("🚦 Kırmızı ışık: Durun!");
            context.SetState(new GreenState());
        }
    }
}
