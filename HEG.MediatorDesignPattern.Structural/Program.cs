using HEG.MediatorDesignPattern.Structural.Mediator;

ConcreteColleague1 colleague1 = new();
ConcreteColleague2 colleague2 = new();
ConcreteMediator mediator = new(colleague1, colleague2);

colleague1.Send("Ping");
colleague2.Send("Pong");
