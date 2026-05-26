namespace HEG.MediatorDesignPattern.Structural.Mediator
{
    public interface IMediator
    {
        void Notify(Colleague sender, string @event);
    }

    public abstract class Colleague
    {
        protected IMediator? Mediator;

        public void SetMediator(IMediator mediator)
        {
            Mediator = mediator;
        }
    }

    public class ConcreteMediator : IMediator
    {
        private readonly ConcreteColleague1 _colleague1;
        private readonly ConcreteColleague2 _colleague2;

        public ConcreteMediator(ConcreteColleague1 colleague1, ConcreteColleague2 colleague2)
        {
            _colleague1 = colleague1;
            _colleague2 = colleague2;
            _colleague1.SetMediator(this);
            _colleague2.SetMediator(this);
        }

        public void Notify(Colleague sender, string @event)
        {
            if (sender == _colleague1)
            {
                _colleague2.Receive($"Mediator routed '{@event}' to colleague 2.");
            }
            else
            {
                _colleague1.Receive($"Mediator routed '{@event}' to colleague 1.");
            }
        }
    }

    public class ConcreteColleague1 : Colleague
    {
        public void Send(string message)
        {
            Console.WriteLine($"Colleague1 sends: {message}");
            Mediator?.Notify(this, message);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"Colleague1 received: {message}");
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public void Send(string message)
        {
            Console.WriteLine($"Colleague2 sends: {message}");
            Mediator?.Notify(this, message);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"Colleague2 received: {message}");
        }
    }
}
