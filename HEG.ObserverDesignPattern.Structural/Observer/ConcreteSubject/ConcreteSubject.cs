namespace HEG.ObserverDesignPattern.Structural.Observer.ConcreteSubject
{
    public class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private string _state = string.Empty;

        public string State
        {
            get => _state;
            set
            {
                _state = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }
    }
}
