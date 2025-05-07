using System.Xml;

// Good use of var because it avoids the repeated type as shown inthe more verbose second statement
var xml1 = new XmlDocument();           // Works with C# 3 and later
XmlDocument xml2 = new XmlDocument();   // Works with all versions of C#

// Bad use of var because we cannot tell the type, so we should use a specific type declaration as shown in the second
// statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

