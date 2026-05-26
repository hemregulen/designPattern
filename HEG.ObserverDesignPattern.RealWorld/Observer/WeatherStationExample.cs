namespace HEG.ObserverDesignPattern.RealWorld.Observer
{
    public record WeatherInfo(double Temperature, double Humidity);

    public interface IWeatherObserver
    {
        void Update(WeatherInfo info);
    }

    public class WeatherStation
    {
        private readonly List<IWeatherObserver> _observers = new();
        private WeatherInfo _weatherInfo = new(0, 0);

        public void Subscribe(IWeatherObserver observer) => _observers.Add(observer);

        public void SetMeasurements(double temperature, double humidity)
        {
            _weatherInfo = new WeatherInfo(temperature, humidity);
            Notify();
        }

        private void Notify()
        {
            foreach (IWeatherObserver observer in _observers)
            {
                observer.Update(_weatherInfo);
            }
        }
    }

    public class TemperatureDisplay : IWeatherObserver
    {
        public void Update(WeatherInfo info)
        {
            Console.WriteLine($"Temperature display: {info.Temperature}°C");
        }
    }

    public class HumidityDisplay : IWeatherObserver
    {
        public void Update(WeatherInfo info)
        {
            Console.WriteLine($"Humidity display: {info.Humidity}%");
        }
    }
}
