using HEG.ObserverDesignPattern.RealWorld.Observer;

WeatherStation station = new();
station.Subscribe(new TemperatureDisplay());
station.Subscribe(new HumidityDisplay());
station.SetMeasurements(24.5, 58);
