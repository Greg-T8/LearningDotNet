

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
