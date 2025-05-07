object height  = 1.88;                   // storing a double in an object
object name    = "Amir";                 // storing a string in an object
Console.WriteLine($"{name} is {height} meteres tall.");
// int    length1 = name.Length;            // compiler error: name is an object, not a string
int    length2 = ((string)name).Length;  //Casting the object to a string
Console.WriteLine($"{name} has {length2} characters.");
