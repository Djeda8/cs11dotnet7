﻿int aa,bb;
Write("Enter a number between 0 and 255: ");
string a = ReadLine();
Write("Enter a number between 0 and 255: ");
string b = ReadLine();

try
{
    aa = Convert.ToInt32(a);
    //aa = int.Parse(a);
    bb = Convert.ToInt32(b);
    //bb = int.Parse(b);

    WriteLine($"{aa} divided by {b} is {aa / bb}");

}
catch (FormatException ex)
{
    WriteLine($"{ex.GetType().Name}: {ex.Message}");
}