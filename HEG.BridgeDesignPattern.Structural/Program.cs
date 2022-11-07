using HEG.BridgeDesignPattern.Structural.Bridge.ConcreteImplementor;
using HEG.BridgeDesignPattern.Structural.Bridge;

Abstraction ab = new RefinedAbstraction();

ab.Implementor = new ConcreteImplementorA();
ab.Operation();

ab.Implementor = new ConcreteImplementorB();
ab.Operation();

Console.ReadKey();
