using HEG.SingletonDesignPattern.RealWorld.Singleton;

AppConfiguration configuration = AppConfiguration.Instance;
configuration.Set("Environment", "Development");
configuration.Set("LogLevel", "Information");

AppConfiguration sameConfiguration = AppConfiguration.Instance;
Console.WriteLine($"LogLevel: {sameConfiguration.Get("LogLevel")}");
sameConfiguration.Display();
