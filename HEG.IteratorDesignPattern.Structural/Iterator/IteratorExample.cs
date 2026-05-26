namespace HEG.IteratorDesignPattern.Structural.Iterator
{
    public interface IIterator
    {
        object First();
        object Next();
        bool IsDone { get; }
        object CurrentItem { get; }
    }

    public interface IAggregate
    {
        IIterator CreateIterator();
    }

    public class ConcreteAggregate : IAggregate
    {
        private readonly List<object> _items = new();

        public IIterator CreateIterator() => new ConcreteIterator(this);

        public int Count => _items.Count;

        public object this[int index]
        {
            get => _items[index];
            set
            {
                if (index == _items.Count)
                {
                    _items.Add(value);
                }
                else
                {
                    _items[index] = value;
                }
            }
        }
    }

    public class ConcreteIterator : IIterator
    {
        private readonly ConcreteAggregate _aggregate;
        private int _current;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public object First()
        {
            _current = 0;
            return _aggregate[_current];
        }

        public object Next()
        {
            _current++;
            return !IsDone ? _aggregate[_current] : string.Empty;
        }

        public bool IsDone => _current >= _aggregate.Count;

        public object CurrentItem => !IsDone ? _aggregate[_current] : string.Empty;
    }
}
