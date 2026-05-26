namespace HEG.FlyweightDesignPattern.Structural.Flyweight
{
    public abstract class Flyweight
    {
        public abstract void Operation(string extrinsicState);
    }

    public class ConcreteFlyweight : Flyweight
    {
        private readonly string _intrinsicState;

        public ConcreteFlyweight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        public override void Operation(string extrinsicState)
        {
            Console.WriteLine($"ConcreteFlyweight: intrinsic={_intrinsicState}, extrinsic={extrinsicState}");
        }
    }

    public class FlyweightFactory
    {
        private readonly Dictionary<string, Flyweight> _flyweights = new();

        public int Count => _flyweights.Count;

        public Flyweight GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new ConcreteFlyweight(key);
            }

            return _flyweights[key];
        }
    }
}
