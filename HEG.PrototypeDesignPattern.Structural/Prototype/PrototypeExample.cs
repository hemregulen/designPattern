namespace HEG.PrototypeDesignPattern.Structural.Prototype
{
    public abstract class Prototype : ICloneable
    {
        protected Prototype(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public abstract object Clone();
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id, string name) : base(id)
        {
            Name = name;
        }

        public string Name { get; set; }
        public override object Clone() => MemberwiseClone();
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id, double value) : base(id)
        {
            Value = value;
        }

        public double Value { get; set; }
        public override object Clone() => MemberwiseClone();
    }
}
