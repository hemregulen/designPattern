using HEG.ChainOfResponsibilityDesignPattern.Structural.ChainOfResponsibility;

Handler handler = new ConcreteHandler1();
handler.SetNext(new ConcreteHandler2()).SetNext(new ConcreteHandler3());

foreach (int request in new[] { 5, 15, 25, 35 })
{
    Console.WriteLine($"Request {request}: {handler.Handle(request)}");
}
