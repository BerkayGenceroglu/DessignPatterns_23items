namespace DesignPattern.Memento.MementoPattern
{
    public class TextEditor
    {
            public string Content { get; set; }

            public Memento Save() => new Memento(Content);
            public void Restore(Memento memento) => Content = memento.State;
    }
}
