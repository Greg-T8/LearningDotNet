int a = 10;
double b = a;       //An int can be safely cast into a double
WriteLine($"a is {a}, b is {b}");

double c = 9.8;
int d = (int)c;     //Explicit cast is required to convert a double to an int
WriteLine($"c is {c}, d is {d}");

long e = 10;
int f = (int)e;     //Explicit cast is required to convert a long to an int
WriteLine($"e is {e:N0}, f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");


WriteLine("{0,12}{1,34}", "Decimal", "Binary");     // 12 and 34 mean right-align with those values
WriteLine("{0,12}{0,34:B32}", int.MaxValue);        // Binary padded to 32 bits
for (int i = 8; i >= -8; i--)
{
    WriteLine("{0,12}{0,34:B32}", i);
}
WriteLine("{0,12}{0,34:B32}", int.MinValue);

long r = 0b_101000101010001100100111010100101010;
int s = (int)r;
Console.WriteLine($"{r,38:B38} = {r}");
Console.WriteLine($"{s,38:B38} = {s}");