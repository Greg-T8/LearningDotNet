// Exploring default values
// Console.WriteLine($"default(int) = {default(int)}");
// Console.WriteLine($"default(bool) = {default(bool)}");
// Console.WriteLine($"default(DateTime) = {default(DateTime)}");
// Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}");  // ?? means "if null, use this value instead"

int number = 13;
Console.WriteLine($"number set to {number}");   // Number set to 13
number = default;
Console.WriteLine($"number set to {number}");   // Number set to 0