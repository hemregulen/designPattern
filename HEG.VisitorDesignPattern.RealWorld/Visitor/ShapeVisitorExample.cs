namespace HEG.VisitorDesignPattern.RealWorld.Visitor
{
    public interface IShapeVisitor
    {
        void VisitCircle(Circle circle);
        void VisitRectangle(Rectangle rectangle);
    }

    public interface IShape
    {
        string Name { get; }
        void Accept(IShapeVisitor visitor);
    }

    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }
        public string Name => "Circle";
        public void Accept(IShapeVisitor visitor) => visitor.VisitCircle(this);
    }

    public class Rectangle : IShape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; }
        public double Height { get; }
        public string Name => "Rectangle";
        public void Accept(IShapeVisitor visitor) => visitor.VisitRectangle(this);
    }

    public class AreaVisitor : IShapeVisitor
    {
        public double Result { get; private set; }

        public void VisitCircle(Circle circle)
        {
            Result = Math.PI * circle.Radius * circle.Radius;
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            Result = rectangle.Width * rectangle.Height;
        }
    }

    public class PerimeterVisitor : IShapeVisitor
    {
        public double Result { get; private set; }

        public void VisitCircle(Circle circle)
        {
            Result = 2 * Math.PI * circle.Radius;
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            Result = 2 * (rectangle.Width + rectangle.Height);
        }
    }
}
