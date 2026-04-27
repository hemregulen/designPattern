using HEG.ObserverDesignPattern.RealWorld.StockMarket;
using HEG.ObserverDesignPattern.RealWorld.StockMarket.ConcreteObserver;

Stock appleStock = new Stock("AAPL", 175.00m);

Investor investor1 = new Investor("Alice", buyThreshold: 160.00m);
Investor investor2 = new Investor("Bob", buyThreshold: 155.00m);
StockAlert highAlert = new StockAlert("High Price Alert", alertThreshold: 180.00m);

appleStock.Attach(investor1);
appleStock.Attach(investor2);
appleStock.Attach(highAlert);

Console.WriteLine("=== Stock Market Observer Pattern Demo ===");

appleStock.Price = 182.50m;
appleStock.Price = 158.00m;
appleStock.Price = 152.00m;

Console.WriteLine("\nRemoving Bob from observers...");
appleStock.Detach(investor2);

appleStock.Price = 185.00m;

Console.ReadKey();
