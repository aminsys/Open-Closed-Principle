namespace open_Closed_Principal
{
    public abstract class ShapeOpenClosed
    {
        public abstract double GetArea();
        public abstract string Type { get; }
    }

    public class Square : ShapeOpenClosed
    {

        private readonly double _width;

        public override string Type => "Square";

        public Square(double width) => _width = width;

        public override double GetArea() => Math.Pow(_width, 2);
    }

    public class Circle : ShapeOpenClosed
    {

        private readonly double _radius;

        public override string Type => "Circle";

        public Circle(double radius) => _radius = radius;

        public override double GetArea() => Math.PI * Math.Pow(_radius, 2);
    }

    public class ScaleneTriangle : ShapeOpenClosed
    {

        private readonly double _a, _b, _c;
        public override string Type => "Scalene Triangle";

        public ScaleneTriangle(double a, double b, double c) => (_a, _b, _c) = (a, b, c);
        public override double GetArea()
        {
            var s = (_a + _b + _c) / 2.0;
            return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
        }
    }

}