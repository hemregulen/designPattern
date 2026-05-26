namespace HEG.ProxyDesignPattern.RealWorld.Proxy
{
    public interface IImage
    {
        void Display();
    }

    public class RealImage : IImage
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading {_fileName} from disk...");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {_fileName}");
        }
    }

    public class ImageProxy : IImage
    {
        private readonly string _fileName;
        private RealImage? _realImage;

        public ImageProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            _realImage ??= new RealImage(_fileName);
            _realImage.Display();
        }
    }
}
