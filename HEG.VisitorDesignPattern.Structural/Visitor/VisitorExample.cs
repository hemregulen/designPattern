namespace HEG.VisitorDesignPattern.Structural.Visitor
{
    public interface IVisitor
    {
        void VisitConcreteElementA(ConcreteElementA element);
        void VisitConcreteElementB(ConcreteElementB element);
    }

    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor) => visitor.VisitConcreteElementA(this);
        public string ExclusiveMethodA() => "A";
    }

    public class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor) => visitor.VisitConcreteElementB(this);
        public string ExclusiveMethodB() => "B";
    }

    public class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA element) => Console.WriteLine($"Visitor1 visited {element.ExclusiveMethodA()}");
        public void VisitConcreteElementB(ConcreteElementB element) => Console.WriteLine($"Visitor1 visited {element.ExclusiveMethodB()}");
    }

    public class ConcreteVisitor2 : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA element) => Console.WriteLine($"Visitor2 visited {element.ExclusiveMethodA()}");
        public void VisitConcreteElementB(ConcreteElementB element) => Console.WriteLine($"Visitor2 visited {element.ExclusiveMethodB()}");
    }
}
