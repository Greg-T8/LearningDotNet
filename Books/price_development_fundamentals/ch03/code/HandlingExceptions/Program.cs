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


#region Throwing overflow exceptions with the checked statement - without checked

int x = int.MaxValue - 1;
WriteLine($"Initial value: {x}");
x++;
WriteLine($"After incrementing: {x}");
x++;
WriteLine($"After incrementing: {x}");
x++;
WriteLine($"After incrementing: {x}");

#endregion


#region Throwing overflow exceptions with the checked statement - with checked

checked
{
    int x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
}

#endregion


#region Throwing overflow exceptions with the checked statement - with try-catch

try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    }
}
catch (OverflowException)
{
    WriteLine("The code overflowed but I caught the exception.");
}

#endregion


#region Disabling compiler overflow checks with the unchecked statement - without unchecked

int y = int.MaxValue + 1;
WriteLine($"y: {y}");

#endregion


#endif

#region Disabling compiler overflow checks with the unchecked statement - with unchecked

unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}

#endregion