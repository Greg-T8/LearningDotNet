#if NORUN
#region Wrapping error-prone code in try-catch blocks

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();

try
{
    int age = int.Parse(input!);
    WriteLine($"You are {age} years old.");
}
catch
{ }

WriteLine("After parsing");

#endregion


#region Catching all exceptions

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();

try
{
    int age = int.Parse(input!);
    WriteLine($"You are {age} years old.");
}
catch (Exception ex) {
    WriteLine($"{ex.GetType()} says {ex.Message}");
};

#endregion


#region Catching specific exceptions

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();

try
{
    int age = int.Parse(input!);
    WriteLine($"You are {age} years old.");
}
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but is either too big or small.");
}
catch (FormatException)
{
    WriteLine("The aged you entered is not a valid number format.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}

#endregion

#endif


#region Catching with filters

Write("Enter an amount: ");
string amount = ReadLine()!;
if (string.IsNullOrEmpty(amount)) return;

try
{
    decimal amountValue = decimal.Parse(amount);
    WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains('$'))         // Exception filter
{
    WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
    WriteLine("Amounts must only contain digits!");
}

#endregion