Console.Write("Enter a number between 0 and 255: ");
string? firstInput = Console.ReadLine();

Console.Write("Enter another number between 0 and 255: ");
string? secondInput = Console.ReadLine();

string currentVar = "";
int firstNumber = 0, secondNumber = 0;
bool hadError = true;
try
{
    currentVar = nameof(firstInput);
    firstNumber = int.Parse(firstInput);
    currentVar = nameof(secondInput);
    secondNumber = int.Parse(secondInput);
    hadError = false;
}
catch (FormatException)
{
    WriteLine($"The variable {currentVar} is not in the correct format.");
}
catch (DivideByZeroException)
{
    WriteLine("Division by zero is not allowed.");
}
catch (OverflowException)
{
    WriteLine($"The variable {currentVar} is outside the range of a byte (0..255).");
}

if (!hadError)
{
    WriteLine($"{firstNumber} divided by {secondNumber} is {firstNumber / secondNumber}");
}
