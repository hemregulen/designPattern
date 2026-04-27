namespace HEG.ObserverDesignPattern.Structural.Observer.ConcreteObserver
{
    public class ConcreteObserver : IObserver
    {
        private readonly string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string state)
        {
            Console.WriteLine($"Observer '{_name}' received update. New state: {state}");
        }
    }
}
