namespace HEG.ChainOfResponsibilityDesignPattern.Structural.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler? _next;

        public Handler SetNext(Handler handler)
        {
            _next = handler;
            return handler;
        }

        public virtual string Handle(int request)
        {
            return _next is not null ? _next.Handle(request) : "No handler could process the request.";
        }
    }

    public class ConcreteHandler1 : Handler
    {
        public override string Handle(int request)
        {
            return request < 10 ? "ConcreteHandler1 handled the request." : base.Handle(request);
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override string Handle(int request)
        {
            return request < 20 ? "ConcreteHandler2 handled the request." : base.Handle(request);
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override string Handle(int request)
        {
            return request < 30 ? "ConcreteHandler3 handled the request." : base.Handle(request);
        }
    }
}
