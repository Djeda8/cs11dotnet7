int x, y;

x = 3;
y = 2 + ++x;
WriteLine($"x = {x} / y = {y}");
WriteLine();

x = 3;
y = 10;
WriteLine($"x = {x} {Convert.ToString(x, 2)} / y = {y} {Convert.ToString(y, 2)}");
x = 3 << 2;
y = 10 >> 1;
WriteLine($"x = {x} {Convert.ToString(x, 2)} / y = {y} {Convert.ToString(y, 2)}");
WriteLine();


WriteLine($"{10} {Convert.ToString(10, 2)} / {8} {Convert.ToString(8, 2)}");
WriteLine($"{10} {Convert.ToString(10, 2)} / {7} {Convert.ToString(7, 2)}");
x = 10 & 8;
y = 10 | 7;
WriteLine($"x = {x} {Convert.ToString(x, 2)} / y = {y} {Convert.ToString(y, 2)}");

