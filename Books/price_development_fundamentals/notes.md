# C#13 and .NET 9 Modern Cross-Platform Development Fundamentals


<img src='images/20250406144058.png' width='250'/><br>

<details>
<summary>Book Resources</summary>

- [Book source code](https://github.com/markjprice/cs13net9)
- [Answers to Test Your Knowledge questions](https://static.packt-cdn.com/downloads/9781835881224_Appendix.pdf?link_from_packtlink=yes)
- [Book Discord](https://packt.link/csharp13dotnet9)
- [Errata](https://github.com/markjprice/cs13net9/blob/main/docs/errata/README.md)
  
</details>

## Dotnet Command Dashboard

```cmd
dotnet --version                                                # Show the SDK version used by the current project
dotnet --info                                                   # Show SDK and runtime versions
dotnet --list-sdks                                              # List all installed SDKs
dotnet --list-runtimes                                          # List all installed runtimes
dotnet new --list                                               # List all templates
dotnet new console --help   


dotnet sln list                                                 # List all projects in the current solution
dotnet new sln --name Chapter01                                 # Create a new solution file in the current folder
dotnet new console -n HelloCS -o .                              # Create a new console app in the current folder
dotnet sln add HelloCS                                          # Add the HelloCS project to the solution 
dotnet new console --output HelloCS                             # Create a new console app in the HelloCS folder
dotnet new console -o AboutMyEnvironment --use-program-main     # Create a new console app without using top-level statements
dotnet new class -n <ClassName>                                 # Create a new class file in the current folder

dotnet build                                                    # Build the current project 
dotnet clean                                                    # Clean the current project  
dotnet run                                                      # Run the current project
```
## C# and .NET Resources
- [Official .NET versions](https://versionsof.net/)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [Alpha .NET versions](https://github.com/dotnet/sdk/blob/main/documentation/package-table.md)
- [C# Language & Feature Timeline (Author's GitHub)](https://github.com/markjprice/cs13net9/blob/main/docs/ch02-features.md)
- [C# Version History](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history)
- [Configure C# Language Version](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version?utm_source=chatgpt.com)
- [Configure Target Framework](https://learn.microsoft.com/en-us/dotnet/standard/frameworks?utm_source)

## My Notes

### Chapter 2: Speaking C#: - The Basics: Types, Variables, and Console Apps
<details>
<summary>Contents - Click to expand</summary>

- [Determine the In-Use Language Version](ch02/notes.md#determine-the-in-use-language-version)
- [Implicitly and Globally Importing Namespaces](ch02/notes.md#implicitly-and-globally-importing-namespaces)
- [Types vs Classes](ch02/notes.md#types-vs-classes)
- [Storing Text](ch02/notes.md#storing-text)
  - [`char` and `string` Types](ch02/notes.md#char-and-string-types)
  - [Outputting Emojis](ch02/notes.md#outputting-emojis)
  - [Verbatim Strings](ch02/notes.md#verbatim-strings)
  - [Raw String Literals](ch02/notes.md#raw-string-literals)
  - [Raw Interpolated String Literals](ch02/notes.md#raw-interpolated-string-literals)
- [Storing Numbers](ch02/notes.md#storing-numbers)
  - [Storing Whole Numbers](ch02/notes.md#storing-whole-numbers)
  - [Using Binary or Hexadecimal Notation](ch02/notes.md#using-binary-or-hexadecimal-notation)
  - [Storing Real Numbers](ch02/notes.md#storing-real-numbers)
  - [Exploring Number Sizes](ch02/notes.md#exploring-number-sizes)
  - [Comparing Double and Decimal Types](ch02/notes.md#comparing-double-and-decimal-types)
    - [Comparing `double` Values](ch02/notes.md#comparing-double-values)
    - [Comparing `decimal` Values](ch02/notes.md#comparing-decimal-values)
  - [Special Real Numbers](ch02/notes.md#special-real-numbers)
  - [New Number Types and Unsafe Code](ch02/notes.md#new-number-types-and-unsafe-code)
- [Storing Booleans](ch02/notes.md#storing-booleans)
- [Storing any type of object](ch02/notes.md#storing-any-type-of-object)
  - [Storing dynamic types](ch02/notes.md#storing-dynamic-types)
- [Declaring local variables](ch02/notes.md#declaring-local-variables)
    - [Specifying the type of a local variable](ch02/notes.md#specifying-the-type-of-a-local-variable)
    - [Inferring the type of a local variable](ch02/notes.md#inferring-the-type-of-a-local-variable)
    - [What does `new` do?](ch02/notes.md#what-does-new-do)
    - [Using target-typed `new` to instantiate objects](ch02/notes.md#using-target-typed-new-to-instantiate-objects)
- [Getting and setting the default value for types](ch02/notes.md#getting-and-setting-the-default-value-for-types)
- [Exploring more about console apps](ch02/notes.md#exploring-more-about-console-apps)
  - [Displaying output to the user](ch02/notes.md#displaying-output-to-the-user)
  - [Formatting using numbered positional arguments](ch02/notes.md#formatting-using-numbered-positional-arguments)
  - [Formatting using interpolated strings](ch02/notes.md#formatting-using-interpolated-strings)
  - [Understanding format strings](ch02/notes.md#understanding-format-strings)
  - [Custom Number Formatting](ch02/notes.md#custom-number-formatting)
- [Getting text input from the user](ch02/notes.md#getting-text-input-from-the-user)
  - [When does `ReadLine` return `null`?](ch02/notes.md#when-does-readline-return-null)
- [Simplifying the usage of the console](ch02/notes.md#simplifying-the-usage-of-the-console)
  - [Importing a static type for a single file](ch02/notes.md#importing-a-static-type-for-a-single-file)
  - [Importing a static type for all code files in a project](ch02/notes.md#importing-a-static-type-for-all-code-files-in-a-project)
- [Getting key input from the user](ch02/notes.md#getting-key-input-from-the-user)
- [Passing arguments to a console app](ch02/notes.md#passing-arguments-to-a-console-app)
- [Setting options with arguments](ch02/notes.md#setting-options-with-arguments)
- [Handling platforms that do not support an API](ch02/notes.md#handling-platforms-that-do-not-support-an-api)
- [Practice Exercise](ch02/notes.md#practice-exercise)
</details>
