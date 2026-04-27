namespace HEG.ObserverDesignPattern.RealWorld.StockMarket.ConcreteObserver
{
    public class StockAlert : IStockObserver
    {
        private readonly string _alertName;
        private readonly decimal _alertThreshold;

        public StockAlert(string alertName, decimal alertThreshold)
        {
            _alertName = alertName;
            _alertThreshold = alertThreshold;
        }

        public void Update(string stockName, decimal price)
        {
            if (price >= _alertThreshold)
            {
                Console.WriteLine($"  [Alert: {_alertName}] {stockName} reached {price:C}! High-price alert triggered.");
            }
        }
    }
}
