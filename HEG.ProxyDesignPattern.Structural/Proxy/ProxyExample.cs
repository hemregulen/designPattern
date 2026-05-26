namespace HEG.ProxyDesignPattern.Structural.Proxy
{
    public interface ISubject
    {
        void Request();
    }

    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: handling request.");
        }
    }

    public class ProxySubject : ISubject
    {
        private RealSubject? _realSubject;

        public void Request()
        {
            Console.WriteLine("Proxy: checking access before forwarding.");
            _realSubject ??= new RealSubject();
            _realSubject.Request();
            Console.WriteLine("Proxy: logging request after forwarding.");
        }
    }
}
