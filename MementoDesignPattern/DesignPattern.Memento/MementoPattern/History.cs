namespace DesignPattern.Memento.MementoPattern
{
    public class History
    {

        private Stack<Memento> _mementos = new Stack<Memento>();
        public void Push(Memento memento) => _mementos.Push(memento);
        public Memento Pop() => _mementos.Pop();
    }
}
