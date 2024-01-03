using System.Xml;

string firstName = "Bob"; // assigning literal strings
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";
// assigning a string returned from the string class constructor
string horizontalLine = new('-', count: 74); // 74 hyphens
// assigning a string returned from a fictitious function
// string address = GetAddressFromDatabase(id: 563);
// assigning an emoji by converting from Unicode
string grinningEmoji = char.ConvertFromUtf32(0x1F600);

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(grinningEmoji);

string fullNameWithTabSeparator = "Bob\tSmith";
Console.WriteLine(fullNameWithTabSeparator);
string filePath = @"C:\televisions\sony\bravia.txt";

string xml = """"
             """
             <person age="50">
               <first_name>Mark</first_name>
             </person>
             """
             """";

Console.WriteLine(xml);



object height = 1.88; // storing a double in an object
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");
// int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");

// storing a string in a dynamic object
// string has a Length property
dynamic something = "Ahmed";
// int does not have a Length property
something = 12;
// an array of any type has a Length property
something = new[] { 3, 5, 7 };

// this compiles but would throw an exception at run-time
// if you later stored a data type that does not have a
// property named Length
Console.WriteLine($"Length is {something.Length}");

var population = 67_000_000; // 67 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds sterling
var fruit = "Apples"; // strings use double-quotes
var letter = 'Z'; // chars use single-quotes
var happy = true; // Booleans have value of true or false

// good use of var because it avoids the repeated type
// as shown in the more verbose second statement
var xml1 = new XmlDocument(); // C# 3 and later
XmlDocument xml2 = new XmlDocument(); // all C# versions

// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

XmlDocument xml3 = new(); // target-typed new in C# 9 or later

// In Program.cs
Person kim = new();
kim.BirthDate = new(1967, 12, 26); // instead of: new DateTime(1967, 12, 26)


List<Person> people = new()
{
    new() { FirstName = "Alice" },
    new() { FirstName = "Bob" },
    new() { FirstName = "Charlie" }
};

Console.WriteLine();

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

Console.WriteLine();

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");

int a = new int();
Console.WriteLine("Valor de a: {0}", a);

// In a separate Person.cs file or at the bottom of Program.cs
public class Person
{
    public string FirstName;
    public DateTime BirthDate;

}