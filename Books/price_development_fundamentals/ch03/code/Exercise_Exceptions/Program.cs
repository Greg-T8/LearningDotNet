// Program: Exercise demonstrating exception handling and integer division.
// Context: Price Development Fundamentals - Chapter 3 exercises.
// Author: Greg Tate
// Description: Prompts the user for two numbers in the range 0-255, parses them,
//              validates the range, and displays the division result.

Console.Write("Enter a number between 0 and 255: ");
string? firstInput = Console.ReadLine();

// Prompt the user for the second number.
Console.Write("Enter another number between 0 and 255: ");
string? secondInput = Console.ReadLine();

// Initialize parsing result variables and an error flag.
int firstNumber = 0, secondNumber = 0;
bool noError = false;
try
{
    firstNumber = int.Parse(firstInput ?? "0");         // Default to 0 if input is null.
    secondNumber = int.Parse(secondInput ?? "0");
    if (firstNumber is < 0 or > 255 || secondNumber is < 0 or > 255) { throw new OverflowException(); }
    noError = true;
}
catch (FormatException)
{
    Console.WriteLine($"The input was not a valid number.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Division by zero is not allowed.");
}
catch (OverflowException) when (firstNumber is < 0 or > 255)
{
    Console.WriteLine($"The first number must be between 0 and 255.");
}
catch (OverflowException) when (secondNumber is < 0 or > 255)
{
    Console.WriteLine($"The second number must be between 0 and 255.");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}

// If parsing and validation succeeded, display the division result.
if (noError)
{
    Console.WriteLine($"{firstNumber} divided by {secondNumber} is {firstNumber / secondNumber}");
}

