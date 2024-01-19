namespace Ch06Ex02Inheritance
{
    public class Rectangle(double height, double width) : Shape(height: height, width: width)
    {
        public override double Area => Height * Width;
    }
}
