namespace HEG.MementoDesignPattern.RealWorld.Memento
{
    public class EditorMemento
    {
        public EditorMemento(string content)
        {
            Content = content;
        }

        public string Content { get; }
    }

    public class TextEditor
    {
        public string Content { get; private set; } = string.Empty;

        public void Type(string text)
        {
            Content += text;
        }

        public EditorMemento Save() => new(Content);

        public void Restore(EditorMemento memento)
        {
            Content = memento.Content;
        }
    }

    public class TextHistory
    {
        private readonly Stack<EditorMemento> _history = new();

        public void Push(EditorMemento memento) => _history.Push(memento);

        public EditorMemento Pop() => _history.Pop();
    }
}
