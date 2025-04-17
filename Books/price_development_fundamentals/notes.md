# C#13 and .NET 9 Modern Cross-Platform Development Fundamentals


<img src='images/20250406144058.png' width='250'/><br>

- [Book source code](https://github.com/markjprice/cs13net9)
- [Answers to Test Your Knowledge questions](https://static.packt-cdn.com/downloads/9781835881224_Appendix.pdf?link_from_packtlink=yes)
- [Book Discord](https://packt.link/csharp13dotnet9)
- [Errata](https://github.com/markjprice/cs13net9/blob/main/docs/errata/README.md)

## Dotnet Commands

```cmd
# General info
dotnet --version         # Show the SDK version used by the current project
dotnet --info            # Show SDK and runtime versions
dotnet --list-sdks
dotnet --list-runtimes
dotnet new --list        # List all templates

# Solution and project setup
dotnet new sln --name Chapter01
dotnet new console --help
dotnet new console --output HelloCS                             # Create a new console app in the HelloCS folder
dotnet sln add HelloCS
dotnet new console -o AboutMyEnvironment --use-program-main     # Create a new console app without using top-level statements
dotnet sln add .\AboutMyEnvironment\
dotnet build
```

## C# and .NET Resources
- [Official .NET versions](https://versionsof.net/)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [Alpha .NET versions](https://github.com/dotnet/sdk/blob/main/documentation/package-table.md)
- [C# Language & Feature Timeline (Author's GitHub)](https://github.com/markjprice/cs13net9/blob/main/docs/ch02-features.md)
- [C# Version History](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history)
- [Configure C# Language Version](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version?utm_source=chatgpt.com)
- [Configure Target Framework](https://learn.microsoft.com/en-us/dotnet/standard/frameworks?utm_source)

### Determine the In-Use Language Version

You can verify the language version in use by including the `#error version`
preprocessor directive. See [Preprocessor
Directives](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives#error-and-warning-information).

Run `dotnet build` to see the error message.

<img src='images/20250412043618.png' width='500'/>
