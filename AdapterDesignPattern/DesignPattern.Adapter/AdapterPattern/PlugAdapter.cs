namespace DesignPattern.Adapter.AdapterPattern
{
    public class PlugAdapter : IRoundPlug
    {
        private readonly SquarePlug _squarePlug;

        public PlugAdapter(SquarePlug squarePlug)
        {
            _squarePlug = squarePlug;
        }

        public void ConnectRound()
        {
            _squarePlug.ConnectSquare();
        }
    }
}
