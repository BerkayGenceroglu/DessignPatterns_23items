namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitRoute>
    {
        private readonly VisitRouteMover _visitRouteMover;
        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            _visitRouteMover = visitRouteMover;
        }

        private int currentIndex = 0;

        public VisitRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if (currentIndex < _visitRouteMover.VisitRouteCount)
            {
                CurrentItem = _visitRouteMover.visitRoutesList[currentIndex++];
                return true;
                //Burada _visitRouteMover.visitRoutesList[0] alınır.
                //CurrentItem → artık listedeki ilk elemanı gösteriyor.
                //currentIndex++ sayesinde index 1 olur.
            }
            return false;
            //Iterator desenini fiilen kullandığın kısım while (iterator.NextLocation()) { ... }
            //döngüsüdür.
        }
    }
}
