namespace DesignPattern.Abstract.AbstractPattern
{
    public class OldFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new OldChair();
        }

        public ITable CreateTable()
        {
            return new OldTable();
        }
    }
}
