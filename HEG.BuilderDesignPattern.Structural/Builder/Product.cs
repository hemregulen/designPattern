namespace HEG.BuilderDesignPattern.Structural.Builder
{
    public class Product
    {
        private readonly List<string> _parts;

        public Product()
        {
            _parts = new List<string>();
        }

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
