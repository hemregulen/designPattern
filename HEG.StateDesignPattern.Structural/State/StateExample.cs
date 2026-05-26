namespace HEG.StateDesignPattern.Structural.State
{
    public interface IState
    {
        void Handle(Context context);
    }

    public class Context
    {
        private IState _state;

        public Context(IState state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(IState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("ConcreteStateA handles request and transitions to ConcreteStateB.");
            context.TransitionTo(new ConcreteStateB());
        }
    }

    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("ConcreteStateB handles request and transitions to ConcreteStateA.");
            context.TransitionTo(new ConcreteStateA());
        }
    }
}
