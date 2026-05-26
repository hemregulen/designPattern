namespace HEG.StrategyDesignPattern.Structural.Strategy
{
    public interface IStrategy
    {
        IEnumerable<string> AlgorithmInterface(IEnumerable<string> data);
    }

    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy(IEnumerable<string> data)
        {
            Console.WriteLine(string.Join(", ", _strategy.AlgorithmInterface(data)));
        }
    }

    public class ConcreteStrategyA : IStrategy
    {
        public IEnumerable<string> AlgorithmInterface(IEnumerable<string> data) => data.OrderBy(item => item);
    }

    public class ConcreteStrategyB : IStrategy
    {
        public IEnumerable<string> AlgorithmInterface(IEnumerable<string> data) => data.OrderByDescending(item => item);
    }
}
