using static System.Convert;        // To use the ToInt32 method
using System.Buffers.Text;          // For Base64Url encoding
using System.Globalization;         // To use CultureInfo

// #define COMMENT_TO_IGNORE

#region CastingConverting
#if COMMENT_TO_IGNORE

// Declare an integer and implicitly cast it to a double
int a = 10;
double b = a;       // An int can be safely cast into a double
WriteLine($"a is {a}, b is {b}");

// Explicitly cast a double to an integer
double c = 9.8;
int d = (int)c;     // Explicit cast is required to convert a double to an int
WriteLine($"c is {c}, d is {d}");

// Explicitly cast a long to an integer
long e = 10;
int f = (int)e;     // Explicit cast is required to convert a long to an int
WriteLine($"e is {e:N0}, f is {f:N0}");

// Demonstrate data loss when casting a large long to an int
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

// Demonstrate data loss when casting a specific large long to an int
e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

// Display decimal and binary representations of integers
WriteLine("{0,12}{1,34}", "Decimal", "Binary");     // 12 and 34 mean right-align with those values
WriteLine("{0,12}{0,34:B32}", int.MaxValue);        // Binary padded to 32 bits
for (int i = 8; i >= -8; i--)
{
    // Loop through integers and display their decimal and binary representations
    WriteLine("{0,12}{0,34:B32}", i);
}
// Display the minimum integer value in decimal and binary
WriteLine("{0,12}{0,34:B32}", int.MinValue);

// Demonstrate casting a large binary long to an int
long r = 0b_101000101010001100100111010100101010;
int s = (int)r;
Console.WriteLine($"{r,38:B38} = {r}"); // Display the binary and decimal representation of the long
Console.WriteLine($"{s,38:B38} = {s}"); // Display the binary and decimal representation of the int

// Use System.Convert to round a double to the nearest integer
double g = 9.8;
int h = ToInt32(g);                     // A method of the System.Convert type
WriteLine($"g is {g}, h is {h}");       // Rounds the number up

// Create a 2D array of doubles and demonstrate rounding behavior
double[,] doubles = {
    { 9.49, 9.5, 9.51 },
    { 10.49, 10.5, 10.51 },
    { 11.49, 11.5, 11.51 },
    { 12.49, 12.5, 12.51 },
    {-12.49, -12.5, -12.51 },
    {-11.49, -11.5, -11.51 },
    {-10.49, -10.5, -10.51 },
    {-9.49, -9.5, -9.51 }
};

// Display the rounding results for each value in the 2D array
WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Write($"| {doubles[x, y],6} | {ToInt32(doubles[x, y]),7} ");
    }
    WriteLine("|");
}
WriteLine();


foreach (double n in doubles)
{
    WriteLine(format:
        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero)
    );
}

int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());


// Allocate an array of 128 bytes
byte[] binaryObject = new byte[128];

// Populate the array with random bytes
Random.Shared.NextBytes(binaryObject);

WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X2} "); // Display each byte in hexadecimal format
}
WriteLine();

// Convert the array to Base64 string and output as text
// string encoded = ToBase64String(binaryObject);
// WriteLine($"Binary Object as Base64: {encoded}");

string encoded = Base64Url.EncodeToString(binaryObject);
WriteLine(encoded);

#endif
#endregion


#region Parsing strings from numbers to dates
#if COMMENT_TO_IGNORE

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("4 June 1980");

WriteLine($"I have {friends} friends to invite to my party.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

#endif
#endregion


#region Avoid Parse exceptions by using the TryParse method
#if COMMENT_TO_IGNORE

Write("How many eggs are there? ");
string? input = ReadLine();
if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else {
    WriteLine("I could not parse the input.");
}

#endif
#endregion
