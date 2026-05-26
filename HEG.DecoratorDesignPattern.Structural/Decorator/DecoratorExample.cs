namespace HEG.DecoratorDesignPattern.Structural.Decorator
{
    public abstract class Component
    {
        public abstract string Operation();
    }

    public class ConcreteComponent : Component
    {
        public override string Operation() => "ConcreteComponent";
    }

    public abstract class Decorator : Component
    {
        protected Decorator(Component component)
        {
            Component = component;
        }

        protected Component Component { get; }

        public override string Operation() => Component.Operation();
    }

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }

        public override string Operation() => $"ConcreteDecoratorA({base.Operation()})";
    }

    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {
        }

        public override string Operation() => $"ConcreteDecoratorB({base.Operation()})";
    }
}
