using System.Xml;

namespace DesignPattern.State.StatePattern
{
    public class YellowState:IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("🚦 Sarı ışık: Hazırlanın!");
            context.SetState(new RedState());
        }
    }
}
