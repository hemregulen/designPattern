using HEG.FlyweightDesignPattern.Structural.Flyweight;

FlyweightFactory factory = new();
Flyweight first = factory.GetFlyweight("X");
Flyweight second = factory.GetFlyweight("Y");
Flyweight reused = factory.GetFlyweight("X");

first.Operation("first call");
second.Operation("second call");
reused.Operation("reused call");
Console.WriteLine($"Flyweights created: {factory.Count}");
