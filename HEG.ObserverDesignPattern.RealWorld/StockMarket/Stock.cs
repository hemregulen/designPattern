namespace HEG.ObserverDesignPattern.RealWorld.StockMarket
{
    public class Stock
    {
        private readonly List<IStockObserver> _observers = new List<IStockObserver>();
        private decimal _price;

        public string Name { get; }

        public Stock(string name, decimal initialPrice)
        {
            Name = name;
            _price = initialPrice;
        }

        public decimal Price
        {
            get => _price;
            set
            {
                Console.WriteLine($"\n[{Name}] Price changed: {_price:C} → {value:C}");
                _price = value;
                Notify();
            }
        }

        public void Attach(IStockObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IStockObserver observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(Name, _price);
            }
        }
    }
}
