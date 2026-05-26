namespace HEG.ChainOfResponsibilityDesignPattern.RealWorld.ChainOfResponsibility
{
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public record Ticket(string Title, Priority Priority);

    public abstract class SupportHandler
    {
        private SupportHandler? _next;

        public SupportHandler SetNext(SupportHandler handler)
        {
            _next = handler;
            return handler;
        }

        public virtual string Handle(Ticket ticket)
        {
            return _next is not null ? _next.Handle(ticket) : $"No support level could process '{ticket.Title}'.";
        }
    }

    public class Level1Support : SupportHandler
    {
        public override string Handle(Ticket ticket)
        {
            return ticket.Priority == Priority.Low ? $"Level 1 resolved '{ticket.Title}'." : base.Handle(ticket);
        }
    }

    public class Level2Support : SupportHandler
    {
        public override string Handle(Ticket ticket)
        {
            return ticket.Priority == Priority.Medium ? $"Level 2 resolved '{ticket.Title}'." : base.Handle(ticket);
        }
    }

    public class Level3Support : SupportHandler
    {
        public override string Handle(Ticket ticket)
        {
            return ticket.Priority == Priority.High ? $"Level 3 resolved '{ticket.Title}'." : base.Handle(ticket);
        }
    }
}
