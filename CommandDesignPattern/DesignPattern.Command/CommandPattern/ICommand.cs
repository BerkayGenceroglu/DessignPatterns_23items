namespace DesignPattern.Command.CommandPattern
{
    public interface ICommand
    {
        void Execute();
        void Undo(); // geri alma desteği için
    }
}
