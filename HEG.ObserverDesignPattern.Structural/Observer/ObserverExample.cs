namespace HEG.ObserverDesignPattern.Structural.Observer
{
    public interface IObserver
    {
        void Update(string state);
    }

    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify();
    }

    public class ConcreteSubject : IObservable
    {
        private readonly List<IObserver> _observers = new();

        public string State { get; set; } = string.Empty;

        public void Subscribe(IObserver observer) => _observers.Add(observer);

        public void Unsubscribe(IObserver observer) => _observers.Remove(observer);

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(State);
            }
        }
    }

    public class ConcreteObserver : IObserver
    {
        private readonly string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string state)
        {
            Console.WriteLine($"{_name} received update: {state}");
        }
    }
}
