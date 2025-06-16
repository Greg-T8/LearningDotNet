/*
    Program: Numeric Type Table Generator
    Context: Book - Price, "C# 12 Development Fundamentals", Chapter 2, Exercise 2.2
    Description: Displays a formatted table of .NET numeric types, their memory size, and value ranges.
    Author: Greg Tate
    Date: 2024-06-15
*/

// Set column widths for table formatting
int typeColumnWidth  = 10;
int bytesColumnWidth = 18;
int minColumnWidth   = 50;
int maxColumnWidth   = 50;
int tableWidth       = typeColumnWidth + bytesColumnWidth + minColumnWidth + maxColumnWidth;

// Define header format string for table columns
string headerFormat = $"{{0,-{typeColumnWidth}}}{{1,-{bytesColumnWidth}}}{{2,{minColumnWidth}}}{{3,{maxColumnWidth}}}";

WriteLine(new string('-', tableWidth));
WriteLine(string.Format(headerFormat, "Type", "Bytes(s) of memory", "Min", "Max"));
WriteLine(new string('-', tableWidth));

// Output rows for each numeric type and their properties
WriteLine(string.Format(headerFormat, "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
WriteLine(string.Format(headerFormat, "byte", sizeof(byte), byte.MinValue, byte.MaxValue));
WriteLine(string.Format(headerFormat, "short", sizeof(short), short.MinValue, short.MaxValue));
WriteLine(string.Format(headerFormat, "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue));
WriteLine(string.Format(headerFormat, "int", sizeof(int), int.MinValue, int.MaxValue));
WriteLine(string.Format(headerFormat, "uint", sizeof(uint), uint.MinValue, uint.MaxValue));
WriteLine(string.Format(headerFormat, "long", sizeof(long), long.MinValue, long.MaxValue));
WriteLine(string.Format(headerFormat, "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue));
unsafe { WriteLine(string.Format(headerFormat, "Int128", sizeof(Int128), Int128.MinValue, Int128.MaxValue)); }
unsafe { WriteLine(string.Format(headerFormat, "UInt128", sizeof(UInt128), UInt128.MinValue, UInt128.MaxValue)); }
unsafe { WriteLine(string.Format(headerFormat, "Half", sizeof(Half), Half.MinValue, Half.MaxValue)); }
WriteLine(string.Format(headerFormat, "float", sizeof(float), float.MinValue, float.MaxValue));
WriteLine(string.Format(headerFormat, "double", sizeof(double), double.MinValue, double.MaxValue));
WriteLine(string.Format(headerFormat, "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue));
