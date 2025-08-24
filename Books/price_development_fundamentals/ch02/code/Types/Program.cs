/*
    Program: Assembly Type and Method Counter
    Synopsis: This program enumerates all referenced assemblies of the current application,
              counts the number of types and methods in each, and prints a summary.
    Context: Book - "C# 12 and .NET 8 – Modern Cross-Platform Development Fundamentals" by Mark J. Price, Chapter 2 Vocabulary.
    Author: Greg Tate
    Date: 2025-04-17
*/

// Import required namespaces for reflection and referenced assemblies
using System.Reflection;

// Demonstrate usage of referenced assemblies
System.Data.DataSet ds = new();
HttpClient client = new();

// Get the entry assembly for the current application
Assembly? myApp = Assembly.GetEntryAssembly();
if (myApp is null) return;

// Enumerate referenced assemblies and count types and methods
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);
    int methodCount = 0;
    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Length;
    }
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name
    );
}