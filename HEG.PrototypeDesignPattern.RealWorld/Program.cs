using HEG.PrototypeDesignPattern.RealWorld.Prototype;

Circle circle = new("Red", 12.5);
Circle circleClone = (Circle)circle.Clone();
circleClone.Color = "Blue";

Rectangle rectangle = new("Green", 10, 20);
Rectangle rectangleClone = (Rectangle)rectangle.Clone();
rectangleClone.Width = 15;

Console.WriteLine(circle.Draw());
Console.WriteLine(circleClone.Draw());
Console.WriteLine(rectangle.Draw());
Console.WriteLine(rectangleClone.Draw());
