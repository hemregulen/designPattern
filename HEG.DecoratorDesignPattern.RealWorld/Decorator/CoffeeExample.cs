namespace HEG.DecoratorDesignPattern.RealWorld.Decorator
{
    public interface ICoffee
    {
        string Description { get; }
        double Cost();
    }

    public class SimpleCoffee : ICoffee
    {
        public string Description => "Simple coffee";
        public double Cost() => 2.50;
    }

    public abstract class CoffeeDecorator : ICoffee
    {
        protected CoffeeDecorator(ICoffee coffee)
        {
            Coffee = coffee;
        }

        protected ICoffee Coffee { get; }
        public abstract string Description { get; }
        public virtual double Cost() => Coffee.Cost();
    }

    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string Description => $"{Coffee.Description}, milk";
        public override double Cost() => base.Cost() + 0.40;
    }

    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string Description => $"{Coffee.Description}, sugar";
        public override double Cost() => base.Cost() + 0.15;
    }

    public class WhipDecorator : CoffeeDecorator
    {
        public WhipDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string Description => $"{Coffee.Description}, whip";
        public override double Cost() => base.Cost() + 0.60;
    }
}
