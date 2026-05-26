namespace HEG.PrototypeDesignPattern.RealWorld.Prototype
{
    public abstract class Shape : ICloneable
    {
        protected Shape(string color)
        {
            Color = color;
        }

        public string Color { get; set; }
        public abstract string Draw();
        public abstract object Clone();
    }

    public class Circle : Shape
    {
        public Circle(string color, double radius) : base(color)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override object Clone() => MemberwiseClone();

        public override string Draw() => $"Circle => Color: {Color}, Radius: {Radius}";
    }

    public class Rectangle : Shape
    {
        public Rectangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public override object Clone() => MemberwiseClone();

        public override string Draw() => $"Rectangle => Color: {Color}, Width: {Width}, Height: {Height}";
    }
}
