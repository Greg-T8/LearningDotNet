/*
Program: Arrays Example
Author: Greg Tate
Date: 2025-08-07
Context: price_development_fundamentals, Chapter 3 - Arrays
Description: Demonstrates array declaration, initialization, and iteration.
*/

// Declare a string array reference and allocate memory for four strings
string[] names;                 // This can reference any size array of strings
names = new string[4];          // Allocate memory for four strings in an array

// Assign names to each element in the array
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

// Iterate through the array and print each name with its position
for (int i = 0; i < names.Length; i++)
{
    WriteLine($"{names[i]} is at position {i}.");
}

// Declare and initialize a string array using array initializer syntax, then print each name with its position
string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" }; // Array initializer syntax
for (int i = 0; i < names2.Length; i++)
{
    WriteLine($"{names2[i]} is at position {i}.");
}


// Declare and initialize a two-dimensional string array, then print its bounds and contents
string[,] grid1 =
{
    { "Alpha", "Beta", "Gamma", "Delta" },
    { "Anne", "Ben", "Charlie", "Doug" },
    { "Aardvark", "Bear", "Cat", "Dog" }
};

// Print the lower and upper bounds of each dimension of the two-dimensional array
WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

// Iterate through the two-dimensional array and print each element with its row and column
for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
    }
}

// Alternative syntax
string[,] grid2 = new string[3, 4];     // Allocate memory
grid2[0, 0] = "Alpha";                  // Assign values
grid2[0, 1] = "Beta";
// And so on
grid[2, 3] = "Dog";
