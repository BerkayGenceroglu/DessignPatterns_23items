namespace DesignPatterns.Prototype.PrototypePattern
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
