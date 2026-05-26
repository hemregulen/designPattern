using HEG.PrototypeDesignPattern.Structural.Prototype;

ConcretePrototype1 prototype1 = new(1, "Alpha");
ConcretePrototype1 clone1 = (ConcretePrototype1)prototype1.Clone();
clone1.Name = "Alpha Clone";

ConcretePrototype2 prototype2 = new(2, 99.9);
ConcretePrototype2 clone2 = (ConcretePrototype2)prototype2.Clone();
clone2.Value = 123.4;

Console.WriteLine($"Original: {prototype1.Id} - {prototype1.Name}");
Console.WriteLine($"Clone: {clone1.Id} - {clone1.Name}");
Console.WriteLine($"Original: {prototype2.Id} - {prototype2.Value}");
Console.WriteLine($"Clone: {clone2.Id} - {clone2.Value}");
