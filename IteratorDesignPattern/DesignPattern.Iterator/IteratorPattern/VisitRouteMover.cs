namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitRoute>
    {
        public List<VisitRoute> visitRoutesList = new List<VisitRoute>();

        public void AddVisitRoute(VisitRoute route)
        {
            visitRoutesList.Add(route);
        }
        public int VisitRouteCount { get=> visitRoutesList.Count ;}
        public IIterator<VisitRoute> CreateIterator()
        {
            return new VisitRouteIterator(this);
        }
    }
}
