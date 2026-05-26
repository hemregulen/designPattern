namespace HEG.StateDesignPattern.RealWorld.State
{
    public interface ITrafficLightState
    {
        string Name { get; }
        void Next(TrafficLightContext context);
    }

    public class TrafficLightContext
    {
        private ITrafficLightState _state;

        public TrafficLightContext(ITrafficLightState state)
        {
            _state = state;
            Console.WriteLine($"Initial state: {_state.Name}");
        }

        public void TransitionTo(ITrafficLightState state)
        {
            _state = state;
            Console.WriteLine($"Transitioned to: {_state.Name}");
        }

        public void Next()
        {
            _state.Next(this);
        }
    }

    public class RedLightState : ITrafficLightState
    {
        public string Name => "Red";
        public void Next(TrafficLightContext context) => context.TransitionTo(new GreenLightState());
    }

    public class GreenLightState : ITrafficLightState
    {
        public string Name => "Green";
        public void Next(TrafficLightContext context) => context.TransitionTo(new YellowLightState());
    }

    public class YellowLightState : ITrafficLightState
    {
        public string Name => "Yellow";
        public void Next(TrafficLightContext context) => context.TransitionTo(new RedLightState());
    }
}
