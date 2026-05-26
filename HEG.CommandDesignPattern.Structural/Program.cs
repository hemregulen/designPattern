using HEG.CommandDesignPattern.Structural.Command;

Receiver receiver = new();
Invoker invoker = new();
invoker.SetCommand(new ConcreteCommand(receiver));
invoker.Run();
