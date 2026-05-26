namespace HEG.CompositeDesignPattern.RealWorld.Composite
{
    public abstract class FileSystemItem
    {
        protected FileSystemItem(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public abstract void Display(int depth);
        public abstract int GetSize();
    }

    public class FileItem : FileSystemItem
    {
        public FileItem(string name, int sizeInKb) : base(name)
        {
            SizeInKb = sizeInKb;
        }

        public int SizeInKb { get; }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string(' ', depth * 2)}- {Name} ({SizeInKb} KB)");
        }

        public override int GetSize() => SizeInKb;
    }

    public class Folder : FileSystemItem
    {
        private readonly List<FileSystemItem> _items = new();

        public Folder(string name) : base(name)
        {
        }

        public void Add(FileSystemItem item)
        {
            _items.Add(item);
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string(' ', depth * 2)}+ {Name}");
            foreach (FileSystemItem item in _items)
            {
                item.Display(depth + 1);
            }
        }

        public override int GetSize() => _items.Sum(item => item.GetSize());
    }
}
