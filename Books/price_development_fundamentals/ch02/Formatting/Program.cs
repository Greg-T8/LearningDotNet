using System.Globalization;     // For CultureInfo
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
int numberOfApples = 12;
decimal pricePerApple = 0.35M; // M indicates a decimal literal

// Console.WriteLine(
//     format: "{0} apples cost {1:C}",
//     arg0: numberOfApples,
//     arg1: pricePerApple * numberOfApples
// );

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);
// WriteToFile(formatted); // Writes the string to a file


// Three parameter values can use named arguments
// Console.WriteLine(
//     format: "{0} {1} lived in {2}",
//     arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

// // Four or more parameter values cannot use named arguments
// Console.WriteLine(
//     "{0} {1} lived in {2} and worked in {3} team at {4}",
//     "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

// The following statement must be all on one line when using C# 10 or earlier. If using C# 11 or later, it can be split
//across multiple lines, but  the break must in the middle of an expression.
// Console.WriteLine($"{numberOfApples} apples cost {pricePerApple
//     * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
Console.WriteLine();
Console.WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name", arg1: "Count");
Console.WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: applesText, arg1: applesCount
);
Console.WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: bananasText, arg1: bananasCount
);


decimal value = 0.325M;
Console.WriteLine("Currency: {0:C}, Percentage: {0:0.0%}", value);