namespace HEG.ObserverDesignPattern.RealWorld.StockMarket
{
    public interface IStockObserver
    {
        void Update(string stockName, decimal price);
    }
}
