
// Exercise 2.1 – Test your knowledge
// 1. What statement can you type in a C# file to discover the compiler and language version?
// #error version

// 2. What are the two types of comments in C#?
// Comment 1
/* Comment 2 */


// 3. What is the difference between a verbatim string and an interpolated string?
using System.Xml;

string filePath = @"C:\televisions\sony\bravia.txt";

var person = new { FirstName = "Alice", Age = 56 };
string json = $$"""
              {
                "first_name": "{{person.FirstName}}",
                "age": {{person.Age}},
                "calculation", "{{{ 1 + 2 }}}"
              }
              """;
Console.WriteLine(json);

// 4. Why should you be careful when using float and double values?
// They are not guaranteed to be accurate

// 5. How can you determine how many bytes a type like double uses in memory?
Console.WriteLine($"Double uses {sizeof(double)} bytes "); 

// 6. When should you use the var keyword?
// To declare declare local variables

// 7. What is the newest syntax to create an instance of a class like XmlDocument?
XmlDocument xml = new();

// 8. Why should you be careful when using the dynamic type?


// 9. How do you right-align a format string?


// 10. What character separates arguments for a console app?
// Space

// Exercise 2.2 – Test your knowledge of number types
// A person’s telephone number
string tel = "07899861628";

// A person’s height
float height = 1.78F;

// A person’s age
int age = 46;

// A person’s salary
decimal salary = 26000.00M;

// A book’s ISBN
string ISBN = "978-1-56619-909-4";

// A book’s price
decimal price = 12.50M;

// A book’s shipping weight
float weight = 1.5F;

// A country’s population
uint population = 1_000_000;
// The number of stars in the universe
ulong starts = 1_000_000_000;

// The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)
int employees = 4_500;