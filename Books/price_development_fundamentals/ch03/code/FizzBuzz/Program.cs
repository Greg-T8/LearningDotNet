/* Program: FizzBuzz example
   Context: Price Development Fundamentals - Chapter 3 - FizzBuzz exercise
   Author: Greg Tate
   Description: Prints Fizz/Buzz/FizzBuzz for numbers 1..MaxNum as part of the chapter examples.
*/
int MaxNum = 100;
for (int i = 1; i <= MaxNum; i++)
{
    string message = "";

    // Determine the Fizz/Buzz/FizzBuzz text for the current number using a switch expression.
    message = i switch
    {
        _ when i % 3 == 0 && i % 5 == 0 => "FizzBuzz",
        _ when i % 3 == 0 => "Fizz",
        _ when i % 5 == 0 => "Buzz",
        _ => i.ToString()
    };

    // Format and write the output: no separator for the final number,
    // newline every 10th item for readability, comma+space otherwise.
    switch (i)
    {
        case int _ when i == MaxNum:
            Write($"{message}");
            break;
        case int _ when i % 10 == 0:
            Write($"{message},\n");
            break;
        default:
            Write($"{message}, ");
            break;
    }
}