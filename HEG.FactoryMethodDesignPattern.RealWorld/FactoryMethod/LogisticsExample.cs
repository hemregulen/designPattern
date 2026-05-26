namespace HEG.FactoryMethodDesignPattern.RealWorld.FactoryMethod
{
    public interface ITransport
    {
        string Deliver();
    }

    public class Truck : ITransport
    {
        public string Deliver() => "Truck delivers goods by road.";
    }

    public class Ship : ITransport
    {
        public string Deliver() => "Ship delivers goods by sea.";
    }

    public abstract class LogisticsCreator
    {
        public abstract ITransport CreateTransport();

        public string PlanDelivery()
        {
            ITransport transport = CreateTransport();
            return $"Logistics plan created: {transport.Deliver()}";
        }
    }

    public class RoadLogistics : LogisticsCreator
    {
        public override ITransport CreateTransport() => new Truck();
    }

    public class SeaLogistics : LogisticsCreator
    {
        public override ITransport CreateTransport() => new Ship();
    }
}
