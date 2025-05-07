dynamic something;
// Storing an array of int values in a dynamic object.
// An array of any type has a Length property.
something = new[] { 3, 5, 7 };

// Storing an int in a dynamic object.
// int does not have a Length property.
// something = 12;

// Storing a string in a dynamic object.
// string has a Length property.
// something = "Ahmed";

// This compiles, but might throw a runtime exception if something is not a string.
Console.WriteLine($"The length of something is {something.Length}.");

// Ouptut the type of the something variable.
Console.WriteLine($"The type of something is {something.GetType()}.");