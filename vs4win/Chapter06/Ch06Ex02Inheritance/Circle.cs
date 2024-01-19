namespace Ch06Ex02Inheritance
{
    public class Circle(double radius) : Shape(height: radius * 2, width: radius * 2)
    {
        public double Radius { get; set; } = radius;

        public override double Area => Math.PI * Radius * Radius;
    }
}
