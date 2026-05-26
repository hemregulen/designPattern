using HEG.StateDesignPattern.RealWorld.State;

TrafficLightContext trafficLight = new(new RedLightState());
for (int i = 0; i < 4; i++)
{
    trafficLight.Next();
}
