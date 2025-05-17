using System.Globalization;     // For CultureInfo
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
int numberOfApples = 12;
decimal pricePerApple = 0.35M; // M indicates a decimal literal

Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);
// WriteToFile(formatted); // Writes the string to a file