namespace DesignPatterns.Composite.CompositePattern
{
    public interface IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalCount();
        public string Display();
    }
}
