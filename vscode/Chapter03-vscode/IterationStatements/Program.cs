using System.Collections;

int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

string? password;
int i = 0;
do
{
    ++i;
    Write(i);
    Write("Enter your password: ");
    password = ReadLine();

}
while (password != "Pa$$w0rd" & i < 5);

if (!String.Equals(password, "Pa$$w0rd"))
{
    WriteLine("Incorrect!");
}
else
{
    WriteLine("Correct!");
}

for (int y = 1; y <= 10; y++)
{
  WriteLine(y);
}

string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
  WriteLine($"{name} has {name.Length} characters.");
}

IEnumerator e = names.GetEnumerator();
while (e.MoveNext())
{
  string name = (string)e.Current; // Current is read-only!
  WriteLine($"{name} has {name.Length} characters.");
}

