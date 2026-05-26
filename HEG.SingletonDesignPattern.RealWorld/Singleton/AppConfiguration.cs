namespace HEG.SingletonDesignPattern.RealWorld.Singleton
{
    public sealed class AppConfiguration
    {
        private static readonly Lazy<AppConfiguration> _instance = new(() => new AppConfiguration());
        private readonly Dictionary<string, string> _settings = new();

        private AppConfiguration()
        {
        }

        public static AppConfiguration Instance => _instance.Value;

        public void Set(string key, string value)
        {
            _settings[key] = value;
        }

        public string Get(string key)
        {
            return _settings.TryGetValue(key, out string? value) ? value : "<missing>";
        }

        public void Display()
        {
            Console.WriteLine("Application configuration:");
            foreach (KeyValuePair<string, string> setting in _settings)
            {
                Console.WriteLine($"- {setting.Key}: {setting.Value}");
            }
        }
    }
}
