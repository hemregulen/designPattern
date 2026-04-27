namespace HEG.ObserverDesignPattern.RealWorld.StockMarket.ConcreteObserver
{
    public class Investor : IStockObserver
    {
        private readonly string _name;
        private readonly decimal _buyThreshold;

        public Investor(string name, decimal buyThreshold)
        {
            _name = name;
            _buyThreshold = buyThreshold;
        }

        public void Update(string stockName, decimal price)
        {
            if (price <= _buyThreshold)
            {
                Console.WriteLine($"  [Investor: {_name}] {stockName} dropped to {price:C}. Buying shares!");
            }
            else
            {
                Console.WriteLine($"  [Investor: {_name}] {stockName} is at {price:C}. Watching...");
            }
        }
    }
}
