using HEG.SingletonDesignPattern.Structural.Singleton;

Singleton first = Singleton.Instance;
Singleton second = Singleton.Instance;

Console.WriteLine(first.Operation());
Console.WriteLine($"Same instance: {ReferenceEquals(first, second)}");
