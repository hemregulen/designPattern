using HEG.StateDesignPattern.Structural.State;

Context context = new(new ConcreteStateA());
context.Request();
context.Request();
