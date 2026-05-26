using HEG.VisitorDesignPattern.RealWorld.Visitor;

IShape[] shapes = [new Circle(5), new Rectangle(4, 6)];

foreach (IShape shape in shapes)
{
    AreaVisitor areaVisitor = new();
    shape.Accept(areaVisitor);

    PerimeterVisitor perimeterVisitor = new();
    shape.Accept(perimeterVisitor);

    Console.WriteLine($"{shape.Name} -> Area: {areaVisitor.Result:0.00}, Perimeter: {perimeterVisitor.Result:0.00}");
}
