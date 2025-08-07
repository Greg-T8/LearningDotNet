/*
Program: Arrays Example
Author: Greg Tate
Date: 2025-08-07
Context: price_development_fundamentals, Chapter 3 - Arrays
Description: Demonstrates array declaration, initialization, and iteration.
*/

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
