using System.Threading;

namespace HEG.SingletonDesignPattern.Structural.Singleton
{
    public sealed class Singleton
    {
        private static int _instanceCounter;
        private static readonly Lazy<Singleton> _instance = new(
            () => new Singleton(),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private Singleton()
        {
            InstanceNumber = Interlocked.Increment(ref _instanceCounter);
        }

        public int InstanceNumber { get; }

        public static Singleton Instance => _instance.Value;

        public string Operation() => $"Singleton instance #{InstanceNumber} is serving the request.";
    }
}
