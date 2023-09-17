WriteLine($"There are {args.Length} arguments.");

ForegroundColor = (ConsoleColor)Enum.Parse(
enumType: typeof(ConsoleColor),
value: args[0],
ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
enumType: typeof(ConsoleColor),
value: args[1],
ignoreCase: true);

CursorSize = int.Parse(args[2]);

WriteLine();

Write("Type your first name and press ENTER: ");
string? firstName = ReadLine();
Write("Type your age and press ENTER: ");
string age = ReadLine();
WriteLine($"Hello {firstName}, you look good for {age}.");

WriteLine();