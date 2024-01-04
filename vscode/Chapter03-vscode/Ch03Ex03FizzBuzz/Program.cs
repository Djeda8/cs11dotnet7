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
    else
    {
        Write(i);
    }
    Write(", ");
}

Console.WriteLine();

for (int i = 0; i < 101; i++)
{
    var message = i switch
    {
        int when (i % 3 == 0 && i % 5 == 0) => "FizzBuzz",
        int when (i % 3 == 0) => "Fizz",
        int when (i % 5 == 0) => "Buzz",
        _ => i.ToString()
    };
    Write(message);
    Write(", ");
}