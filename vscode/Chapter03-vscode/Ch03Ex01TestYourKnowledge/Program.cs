// What happens when you divide an int variable by 0?
int a = 4;
int b = 0;
// int result = a / b;
// Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.

// What happens when you divide a double variable by 0?
double c = 4.0d;
int d = 0;
double result = c / d;// The result is infinite
WriteLine(result);
WriteLine();


// What happens when you overflow an int variable, that is, set it to a value beyond its range?
int e = int.MaxValue;
++e;
WriteLine(e); // Result is equal to -2147483648
WriteLine();


// What is the difference between x = y++; and x = ++y;?
int y = 5;
WriteLine($"{y++}");
WriteLine($"{y}");
WriteLine($"{++y}");
WriteLine();


// What is the difference between break, continue, and return when used inside a loop statement?
Write("First ");
for (int j = 0; j < 10; j++)
{
    if (j == 5)
    {
        //break;
        continue;
        //return;
    }
    Write(j + " ");
}
Write(" The end");
WriteLine();


// What are the three parts of a for statement and which of them are required?
int i = 0;
for (; i < 10; i++)
{
    Write($"{i} ");
}
WriteLine();


// What is the difference between the = and == operators?
int f = 4;
if (f == 4)
{
    WriteLine("f is equal 4");
}

// Does the following statement compile?
// for (; ; );


// What does the underscore _ represent in a switch expression?
// the default case

// What interface must an object “implement” to be enumerated over using the foreach statement?
//IEnumerator

WriteLine("This is the end");