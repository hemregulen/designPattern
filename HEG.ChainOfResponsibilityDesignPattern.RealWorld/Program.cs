using HEG.ChainOfResponsibilityDesignPattern.RealWorld.ChainOfResponsibility;

SupportHandler support = new Level1Support();
support.SetNext(new Level2Support()).SetNext(new Level3Support());

Ticket[] tickets =
[
    new Ticket("Printer issue", Priority.Low),
    new Ticket("Database timeout", Priority.Medium),
    new Ticket("Production outage", Priority.High)
];

foreach (Ticket ticket in tickets)
{
    Console.WriteLine(support.Handle(ticket));
}
