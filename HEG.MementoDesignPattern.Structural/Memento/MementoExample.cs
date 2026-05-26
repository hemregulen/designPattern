namespace HEG.MementoDesignPattern.Structural.Memento
{
    public class Memento
    {
        public Memento(string state)
        {
            State = state;
        }

        public string State { get; }
    }

    public class Originator
    {
        public string State { get; set; } = string.Empty;

        public Memento CreateMemento() => new(State);

        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
    }

    public class Caretaker
    {
        private readonly List<Memento> _mementos = new();

        public void Add(Memento memento) => _mementos.Add(memento);

        public Memento Get(int index) => _mementos[index];
    }
}
