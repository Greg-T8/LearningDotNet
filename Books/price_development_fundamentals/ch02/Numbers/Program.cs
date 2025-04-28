

// An unsigned integer is a positive whole number or 0
uint naturalNumber = 23;

// An integer is a negative number or positive whole number or 0
int integerNumber = -23;

// A float is a single-precision floating-point number
// The F or f suffix makes the value a float literal
// The suffix is required to compile
float realNumber = 2.3f;

// A double is a double-precision floating-point number
// double is the default type for floating-point literals
double anotherRealNumber = 2.3; // A double literal value


int decimalNotation = 2_000_000; // Note use of digit separator for readability
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// Check the three variables have the same value
Console.WriteLine($"{decimalNotation == binaryNotation}"); // True
Console.WriteLine($"{decimalNotation == hexadecimalNotation}"); // True

// Output the variable values in decimal.
Console.WriteLine($"{decimalNotation:N0}"); // 2,000,000
Console.WriteLine($"{binaryNotation:N0}"); // 2,000,000
Console.WriteLine($"{hexadecimalNotation:N0}"); // 2,000,000

// Output the variable values in hexadecimal.
Console.WriteLine($"{decimalNotation:X}"); // 1E8400
Console.WriteLine($"{binaryNotation:X}"); // 1E8400
Console.WriteLine($"{hexadecimalNotation:X}"); // 1E8400

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers from {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers from {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers from {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine("Using decimals:");
decimal c = 0.1M; // M suffix makes it a decimal literal
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}


#region Special float and double values
Console.WriteLine($"double.Epsilon: {double.Epsilon}"); // 4.94065645841247E-324
Console.WriteLine($"double.Epsilon to 324 decimal places: {double.Epsilon:N324}"); // 0.
Console.WriteLine($"double.Epsilon to 330 decimal places: {double.Epsilon:N330}"); // 0.
const int col1 = 37; // First column width
const int col2 = 6; // Second column width
string line = new string('-', col1 + col2 + 3);
Console.WriteLine(line);
Console.WriteLine($"{"Expression",-col1} | {"Value",col2}");
Console.WriteLine(line);
Console.WriteLine($"{"double.NaN",-col1} | {double.NaN,col2}");
Console.WriteLine($"{"double.PositiveInfinity",-col1} | {double.PositiveInfinity,col2}");
Console.WriteLine($"{"double.NegativeInfinity",-col1} | {double.NegativeInfinity,col2}");
Console.WriteLine(line);
Console.WriteLine($"{"0.0 / 0.0",-col1} | {0.0 / 0.0,col2}");
Console.WriteLine($"{"3.0 / 0.0",-col1} | {3.0 / 0.0,col2}");
Console.WriteLine($"{"-3.0 / 0.0",-col1} | {-3.0 / 0.0,col2}");
Console.WriteLine($"{"3.0 / 0.0 == double.PositiveInfinity",-col1} | {3.0 / 0.0 == double.PositiveInfinity,col2}");
Console.WriteLine($"{"-3.0 / 0.0 == double.NegativeInfinity",-col1} | {-3.0 / 0.0 == double.NegativeInfinity,col2}");
Console.WriteLine($"{"0.0 / 3.0",-col1} | {0.0 / 3.0,col2}");
Console.WriteLine($"{"0.0 / -3.0",-col1} | {0.0 / -3.0,col2}");
Console.WriteLine(line);
#endregion

unsafe
{
    Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers from {Half.MinValue:N0} to {Half.MaxValue:N0}.");
    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers from {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
}