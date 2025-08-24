// Program Description:
// This program retrieves and prints the namespace of the current Program class.
// It then throws an exception to demonstrate error handling or debugging scenarios.
//
// Context:
// This example is from Chapter 1 of the book "Price Development Fundamentals."
//
// Author: Greg Tate
// Date: 2025-04-06

// It prints the following output:
// Namespace: <null>
// Unhandled exception. System.Exception: Exception of type 'System.Exception' was thrown.
//    at Program.<Main>$(String[] args) in C:\price_development_fundamentals\ch01\HelloCS\Program.cs:line 3


string name = typeof(Program).Namespace ?? "<null>";
Console.WriteLine($"Namespace: {name}");
throw new Exception();
