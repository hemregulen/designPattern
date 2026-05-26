using HEG.DecoratorDesignPattern.RealWorld.Decorator;

ICoffee coffee = new SimpleCoffee();
coffee = new MilkDecorator(coffee);
coffee = new SugarDecorator(coffee);
coffee = new WhipDecorator(coffee);

Console.WriteLine($"Order: {coffee.Description}");
Console.WriteLine($"Price: ${coffee.Cost():0.00}");
