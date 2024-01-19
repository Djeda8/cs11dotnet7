namespace Ch06Ex02Inheritance
{
    public class Square(int side) : Shape(height: side, width: side)
    {
        public override double Area => Height* Width;
    }
}
