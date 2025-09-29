namespace DesignPattern.Abstract.AbstractPattern
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }
}
