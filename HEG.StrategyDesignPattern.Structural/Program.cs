using HEG.StrategyDesignPattern.Structural.Strategy;

Context context = new(new ConcreteStrategyA());
context.ExecuteStrategy(new[] { "delta", "alpha", "charlie" });
context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy(new[] { "delta", "alpha", "charlie" });
