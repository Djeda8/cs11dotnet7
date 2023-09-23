partial class Program
{
    static int Factorial(int number)
    {
        Write(number);
        if (number < 0)
        {   
            throw new ArgumentException(message: $"The factorial function is defined for non-negative integers only.Input: {number}", paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked // for overflow
            {
                return number * Factorial(number - 1);
            }
        }
    }

    static void RunFactorial()
    {
        for (int i = 1; i <= 15; i++)
        {
            WriteLine($" {i}! = {Factorial(i):N0}");
        }
    }
}