namespace Ch06Ex02Inheritance
{
    public abstract class Shape(double height, double width)
    {
        public double Height { get; set; } = height;
        public double Width { get; set; } = width;
        public abstract double Area { get; }
    }
}
