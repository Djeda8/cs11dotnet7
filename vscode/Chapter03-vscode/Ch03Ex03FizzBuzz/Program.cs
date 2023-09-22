for (int i = 0; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Write("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Write("Fizz");
    }
    else if (i % 5 == 0)
    {
        Write("Buzz");
    }
    else{
        Write(i);
    }
    Write(", ");
}
