using HEG.FactoryMethodDesignPattern.Structural.FactoryMethod;

Creator creatorA = new ConcreteCreatorA();
Creator creatorB = new ConcreteCreatorB();

Console.WriteLine(creatorA.SomeOperation());
Console.WriteLine(creatorB.SomeOperation());
