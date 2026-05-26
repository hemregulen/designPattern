using HEG.VisitorDesignPattern.Structural.Visitor;

IElement[] elements = [new ConcreteElementA(), new ConcreteElementB()];
IVisitor visitor1 = new ConcreteVisitor1();
IVisitor visitor2 = new ConcreteVisitor2();

foreach (IElement element in elements)
{
    element.Accept(visitor1);
    element.Accept(visitor2);
}
