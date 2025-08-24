// Program Description:
// This program displays information about the current environment, including the current directory,
// the operating system version, and the namespace of the Program class.
//
// Context:
// This example is from Chapter 1 of the book "Price Development Fundamentals."
//
// Author: Greg Tate
// Date: 2025-04-06

namespace AboutMyEnvironment;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Environment.CurrentDirectory);
        Console.WriteLine(Environment.OSVersion.VersionString);
        Console.WriteLine("Namespace: {0}", typeof(Program).Namespace ?? "<null>");
    }
}
