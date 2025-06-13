Console.Write("Type your first name and press ENTER: ");
string? firstName = Console.ReadLine();                             // Use of the nullable refernce type annotation
Console.Write("Type your age and press ENTER: ");
string age = Console.ReadLine()!;                                   // Use of the null-forgiving operator
Console.WriteLine($"Hello {firstName}, you look good for {age}.");