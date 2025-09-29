namespace DesignPattern.State.StatePattern
{
    public class GreenState:IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("🚦 Yeşil ışık: Araçlar geçebilir.");
            context.SetState(new YellowState()); // sıradaki state
        }
    }
}
