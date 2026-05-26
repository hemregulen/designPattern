namespace HEG.CompositeDesignPattern.Structural.Composite
{
    public abstract class Component
    {
        protected Component(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
        }

        public override void Remove(Component component)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");
        }
    }

    public class Composite : Component
    {
        private readonly List<Component> _children = new();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");
            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
