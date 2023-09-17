int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
format: "{0} apples cost {1:C}",
arg0: numberOfApples,
arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
format: "{0} apples cost {1:C}",
arg0: numberOfApples,
arg1: pricePerApple * numberOfApples);
//WriteToFile(formatted); // writes the string into a file

// Four parameter values can use named arguments.
Console.WriteLine(
format: "{0} {1} lived in {2}",
arg0: "Roger", arg1: "Cevung",
arg2: "Stockholm");
// Five or more parameter values cannot use named arguments.
Console.CursorVisible = true;
Console.CursorSize = 50;
Console.WriteLine(
format: "{0} {1} lived in {2}, {3} and worked in the {4} team at {5}.",
"Roger", "Cevung", "Stockholm", "Sweden", "Education", "Optimizely");
