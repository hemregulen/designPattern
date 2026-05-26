namespace HEG.FactoryMethodDesignPattern.Structural.FactoryMethod
{
    public interface IProduct
    {
        string Operation();
    }

    public class ConcreteProductA : IProduct
    {
        public string Operation() => "Result from ConcreteProductA";
    }

    public class ConcreteProductB : IProduct
    {
        public string Operation() => "Result from ConcreteProductB";
    }

    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            IProduct product = FactoryMethod();
            return $"Creator worked with {product.Operation()}";
        }
    }

    public class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod() => new ConcreteProductA();
    }

    public class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod() => new ConcreteProductB();
    }
}
