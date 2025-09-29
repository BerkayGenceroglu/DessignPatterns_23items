namespace DesignPattern.Iterator.IteratorPattern
{
    public interface IIterator<T>
    {
        T CurrentItem { get; }
        bool NextLocation();
    }
}
//Interface → sözleşme (imza).
//Class → sözleşmeyi yerine getiren gerçek uygulama.
