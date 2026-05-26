using HEG.DecoratorDesignPattern.Structural.Decorator;

Component component = new ConcreteComponent();
Component decorated = new ConcreteDecoratorB(new ConcreteDecoratorA(component));

Console.WriteLine(component.Operation());
Console.WriteLine(decorated.Operation());
