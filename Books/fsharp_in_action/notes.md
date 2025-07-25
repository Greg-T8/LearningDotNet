# F# In Action
<img src='images/20250408025735.png' width='250'/>

<details>

<summary>Book Resources</summary>

- [Book Code](https://github.com/isaacabraham/fsharp-in-action)
</details>


<!-- omit in toc -->
## DotNet Commands
```cmd
# Create a new solution
dotnet new sln --name HelloFSharp

# Create a new F# project
dotnet new console -lang F# -o HelloFSharp

# Add the project to the solution
dotnet sln add HelloFSharp

# Run the project
dotnet run

# Start the FSI (F# Interactive) REPL
dotnet fsi
```
<!-- omit in toc -->
## FSI Commands
```fsharp
System.Console.Clear()  // Clear the console
```

<!-- omit in toc -->
## Contents

- [1. Introducing F#](#1-introducing-f)
  - [About F# and Functional Programming](#about-f-and-functional-programming)
    - [Imperative Code vs Declarative Code](#imperative-code-vs-declarative-code)
    - [Composability](#composability)
    - [Data and behavior](#data-and-behavior)
  - [A smarter compiler](#a-smarter-compiler)
  - [F# and .NET](#f-and-net)
- [2. Hands on with F#](#2-hands-on-with-f)
  - [2.5 REPL and F# Scripts](#25-repl-and-f-scripts)
  - [2.5 F# Scripts](#25-f-scripts)
    - [2.5.4 State inthe REPL](#254-state-inthe-repl)
    - [2.5.5 Creating your first function](#255-creating-your-first-function)
  - [2.6 Where scripts and the REPL fit in](#26-where-scripts-and-the-repl-fit-in)
- [3. F# Syntax Basics](#3-f-syntax-basics)
  - [3.1 F# syntax basics](#31-f-syntax-basics)
    - [3.1.1 Characteristics of F# syntax](#311-characteristics-of-f-syntax)
      - [Readability](#readability)
      - [Sensible defaults](#sensible-defaults)
      - [Consistency](#consistency)
      - [A worked example](#a-worked-example)
    - [3.1.2 The `let` keyword](#312-the-let-keyword)
    - [3.1.3 Scoping](#313-scoping)
      - [Curly brace vs whitespace indention](#curly-brace-vs-whitespace-indention)
      - [Nested scopes](#nested-scopes)
      - [Nested functions](#nested-functions)
      - [Accessing outer scoped values](#accessing-outer-scoped-values)
      - [Cyclical dependencies](#cyclical-dependencies)
  - [3.2 Type Inference](#32-type-inference)
    - [3.2.1 Benefits of type inference](#321-benefits-of-type-inference)
    - [3.2.2 Type inference basics](#322-type-inference-basics)
    - [3.2.3 Inferring generics](#323-inferring-generics)
      - [Automatic Generalization](#automatic-generalization)
    - [3.2.4 Diagnosing unexpected type inference](#324-diagnosing-unexpected-type-inference)
    - [3.2.5 Limitations of type inference](#325-limitations-of-type-inference)
    - [3.2.6 Criticisms of type inference](#326-criticisms-of-type-inference)
- [4. F# Fundamentals](#4-f-fundamentals)
  - [4.1 Expressions](#41-expressions)
    - [4.1.1 Purity and side effects](#411-purity-and-side-effects)
    - [4.1.2 Difficulties with statements](#412-difficulties-with-statements)
    - [4.1.3 Expressions to the rescue](#413-expressions-to-the-rescue)
    - [4.1.4 Expressions in F#](#414-expressions-in-f)
    - [4.1.5 Composability](#415-composability)
      - [Refactoring to functions](#refactoring-to-functions)
    - [4.1.6 Unit](#416-unit)
      - [Unit as an input](#unit-as-an-input)
      - [Unit and side effects](#unit-and-side-effects)
    - [4.1.7 Ignore](#417-ignore)
  - [4.2 Immutable Data](#42-immutable-data)
    - [4.2.1 The problem with mutability](#421-the-problem-with-mutability)
    - [4.2.2 Modeling with mutable and immutable data](#422-modeling-with-mutable-and-immutable-data)
    - [4.2.3 Optimizing and opinionated languages](#423-optimizing-and-opinionated-languages)
      - [Working with immutable data: a worked example](#working-with-immutable-data-a-worked-example)
    - [4.2.4 Other benefits of immutable data](#424-other-benefits-of-immutable-data)
- [5. Shaping Data](#5-shaping-data)


## 1. Introducing F#

### About F# and Functional Programming


> To use F# effectively, quoting Yoda, "you must unlearn what you have learned."


**F# Mental Model:**  

<img src='images/20250408025610.png' width='450'/>

#### Imperative Code vs Declarative Code

We are used to writing imperative code. F# is a functional-first language, which uses declarative code. According to the author, "if you're used to imperative model of developing, it can feel like giving up control. However, once you're used to [functional programming], it's very difficult to go back."

- Imperative code - the low-level "how", which focuses on step-by-step instructions.
- Declarative code - the high-level "what", which focuses on the end result, leaving the low-level details to the compiler

<img src='images/20250408030753.png' width='400'/>

In the example above, the imperative version takes ownership of *how* we want to
filter the numbers&mdash;by creating an intermediary list, iterating through
each one, etc.

#### Composability

Functions are the main component of F# programs, rather than classes. F#
emphasizes composition over inheritance, which is a common theme in functional
programming. This means that you can build complex functions by combining
simpler ones, rather than relying on a rigid class hierarchy.

<img src='images/20250408031523.png' width='400'/>

#### Data and behavior

A key pattern in F# is the separation of data and behavior. In F#, you typically
define your data types separately from the functions that operate on them.
Instead of having classes that encapsulate both data and behavior, you define
simple data types with modules of functions that operate on them.

In the OO world, you might have a `Basket` class with methods like `AddItem`,
`Clear`, and `Checkout`, plus the internal *encapsulated* state, i.e. what items
are in the basket. When you call methods on them, they would perform some action
and modify that internal state.

In the FP world, you have an *immutable* record that stores the *current* state
of the basket and a module with *stateless* functions such as `AddItem`,
`Clear`, and `Checkout`. Each function performs some action and returns an
updated version of the basket, rather than modifying the original one. This
generally leads to more predictable and testable code.

### A smarter compiler

F# inevitably changes how you write code. F# helps a great deal in reducing
boilerplate activities.

F# encourages a safer, more deliberate coding style by making it impossible to
ignore changes to your types—your code won’t compile until every usage is
updated. This eliminates a whole class of bugs (like null reference exceptions)
*at compile time* without relying on unit tests. The result is fewer runtime
surprises and less debugging, all thanks to the compiler doing more of the work
for you.

### F# and .NET

- You can reference any .NET assembly from F#
- You can consume and create classes with inheritance, interfaces, properties, and methods
- F# permits you to mix both FP and OO styles

<img src='images/20250418034314.png' width='300'/>


## 2. Hands on with F#


```fsharp
let name = "Greg"
let time = System.DateTime.UtcNow
printfn $"Hello from F#! My name is {name}, the time is {time}"
```

See [HelloFSharp](./ch02/HelloFSharp/Program.fs) for the code.


### 2.5 REPL and F# Scripts

- Use F# Interactive (FSI) to run F# code interactively.
- FSI is a REPL (Read-Eval-Print Loop) for F#, which supports interactive coding.
- Use `dotnet fsi` command to start the REPL.

<img src='images/20250418040022.png' width='450'/>

- Use two semicolons `;;` at the end to execute the text currently in the buffer.
- `val` is the default symbol expressions are bound to if you don't use `let`.

### 2.5 F# Scripts

- F# scripts are files with the `.fsx` extension.
- F# scripts do not require a project or solution and can be executed as a single file.

> When working in VS Code, use the [Ionide](https://github.com/ionide/ionide-vscode-fsharp) extension.

- With the Ionide extension, use the VS Code command `FSI: Send Selection` to send the selected code to the REPL.

<img src='images/20250418041304.png' width='450'/>

#### 2.5.4 State inthe REPL

- The REPL is stateful in that it allows you to access data and arbitrarily interrogate and create new values from them.

![Using the REPL](./images/2025-04-29_03-07-58.gif)

Things to note from the above image:
- You start (or restart) the FSI using the command `FSI: Start`.
- You can execute lines using `FSI: Send Line`.
- You can directly execute commands in the console, but you need to use `;;` to terminate the command.

#### 2.5.5 Creating your first function

The following function takes in someone's name and age and returns a string that's a greeting of the person.

```fsharp
let greetPerson name age =
    $"Hello {name}. You are {age} years old."

greetPerson "Fred" 21
```
<img src='images/20250429034812.png' width='550'/>

**Note:**  
- `a` and `b` represent *generic* types, indicating `name` and `age` can be of any type&mdash;string, integer, or customer.
- Use the command `FSI: Send Selection` to send the selected code to the REPL.

### 2.6 Where scripts and the REPL fit in

A lot of development can be done using scripts, particularly in the exploratory phase, where you create a new module or component in your application and want to start by sketching a rough idea before formalizing it.

<img src='images/20250429035333.png' width='500'/>

Typically, you start with a script and then port it into a full application, whether that application be console, background service, web application, etc. From there, you establish end-to-end tests and regression test. Furthermore, the author notes that no test-driven development is needed.

## 3. F# Syntax Basics

### 3.1 F# syntax basics

#### 3.1.1 Characteristics of F# syntax

F#'s syntax goal is to be highly succint and highly safe. Most fans of dynamic languages complain that the syntax of statically typed languages is too verbose. Fans of statically typed languages point out that refactoring is difficult without a type checker and compiler and potentially affects scaling a team without writing a large number of unit tests.

F# hits a sweet spot between the two: it's lightweight, readable, and type-safe all at the same time.

In terms of syntax, F# is succinct in that it strips away unnecessary symbols and keywords that other languages rely on, resulting in code having a far greater percentage of text relating to business logic than syntax.

##### Readability

F# has a relatively small number of symbols and characters needed for different features. For example, instead of negation being `!`, F# uses `not`. This lightweight syntax makes it easy to create a *domain specific language* and write code for nontechnical people.

##### Sensible defaults

F# has defaults optimized for most common cases, which means you'll spend less time writing code to satisfy the compiler.

An example of this is public vs private status. Public is the default, so you don't have to specify it. In C#, you have to specify `public`.

##### Consistency 

Functions and values are declared using the same pattern and syntax:

```fsharp
let myFunction arg1 arg2 =  // A function definition, taking in two arguments, arg1 and arg2 (implementation omitted)
let mySimpleValue = 99      // The definition of mySimpleValue, an integer
```
**Note:** both use `let` to declare a value or function. 

##### A worked example

```fsharp
let addTenThenDouble theNumber =                            // 1.
    let addedTen = theNumber + 10                           // 2.
    let answer = addedTen * 2                               // 3.
    printfn $"({theNumber} + 10) * 2 is {answer}"           // 4.
    let website = System.Uri "https://fsharp.org"
    answer                                                  // 5.
```
**Note:**
1. *No parentheses*: F# uses parentheses in a few places, but they are usually not required to signify the start and end of arguments to a function.
2. *No curly braces*: F# is whitespace-sensitive and expects all lines within any scope to start at the same column.
3. *No semicolons*: F# doesn't require semicolons to terminate lines. 
4. *No `new` keyword*: F# thinks of a constructor on a type as a static function instead of as some kind of unique construct.
5. *No `return` keyword*: The last expression of a function is automatically the return value; therefore, there is no need to use the `return` keyword.
6. *No type annotations*: F# doesn't require any guidance from you for the types of values, yet it is a type-safe language.

#### 3.1.2 The `let` keyword

The `let` keyword is the most important keyword in F#. It allows you to bind values to symbols.

```fsharp
let doACalculation theNumber =                          // Binds a function to the symbol doACalculation
    let twenty = 20                                     // Binds the value 20 to the symbol twenty 
    let answer = twenty + theNumber                     // Binds the result of the calculation to the symbol answer
    let foo = System.Uri "https://www.fsharp.org"       // Binds a System.Uri object to the symbol foo
    answer                                              
```

**Note:** Functions are just values. Some values take in arguments, and others don't. You can treat them the same way, i.e. you can pass them around in your application as arguments, bind them to symbols, and so on. 

Think of `let` as a copy and paste instruction: whenever you see this symbol used in code, replace it with the value on the right-hand side of the `=` sign. 

```fsharp
let isaac = 42                  // Binds the value 42 to the symbol isaac
let olderIsaac = isaac + 1      // References the symbol isaac to get the value 42
let youngerIsaac = isaac - 1
```

Code above becomes:

```fsharp
let olderIsaac = 42 + 1
let youngerIsaac = 42 - 1
```

**Note:** Some languages use the `var` keyword to perform what appears to be the same thing as `let`, but this is not the case. `var` declares variables, which can vary by being assigned different values or by being mutated. `let` creates an immutable reference to a value. Once you've bound a value to a symbol, you can't change it to reference another value later.

#### 3.1.3 Scoping

In F# terms, scoping means the lifetime in which other parts of code can reference a symbol.

##### Curly brace vs whitespace indention

Take the following fictional F# function `foo` styles:

```fsharp
let foo arg1 arg2 arg3 =
  body
  body
  body
```
**Note:**
- F# uses whitespace indentation to signify the start and end of a scope, rather than curly braces.
- F# doesn't allow the use of tabs as a valid token

**Exercise 3.1:** Create a function that takes in three numbers as input arguments. Add the first two together and bind it to a symbol inProgress. Then, multiply that by the third argument and bind it to a symbol answer. Finally, return a string that says The answer is {answer} using string interpolation.

```fsharp
let foo num1 num2 num3 =
    let inProgress = num1 + num2
    let answer = inProgress * num3
    $"The answer is {answer}"
```
**Output:**
```cmd
> #load "Ex_3.1.fsx";;
[Loading c:\Users\gregt\LocalCode\LearningDotNet\Books\fsharp_in_action\ch03\Ex_3.1.fsx]
module FSI_0007.Ex_3.1
val foo: num1: int -> num2: int -> num3: int -> string

> foo 2 3 4;;
val it: string = "The answer is 20"
```

##### Nested scopes

Nested scopes are rarely used in curly brace languages, but they are common in F# to create arbitrary scopes inside of scopes. They are useful because they allow you to clearly indicate to the reader the scope of a piece of data.

The more tightly scoped a value is, the less of a chance of it being misused, leading to bugs.

```fsharp
let fname = "Frank"
let sname = "Schmidt"
let fullName = $"{fname} {sname}"               // Uses two previously defined symbols to create a third
let greetingText = $"Greetings, {fullname}"     // Uses the previously defined symbol to create a fourth
```
**Note:**
- `fname` and `sname` are only used to create `fullName`, so they are tightly scoped.
- Similarly, `fullName` is only used to create `greetingText`, so it is tightly scoped.

Rewriting the above code to use nested scopes:

```fsharp
let greetingText =              // Outermost scope
  let fullName =                // Nested scope
    let fname = "Frank"         // Intermediary symbols only accessible within scope of `fullName` block
    let sname = "Schmidt"
    $"{fname} {sname}"
  $"Greetings, {fullName}"
```

##### Nested functions

```fsharp
let greetingTextWithFunction person =
  let makeFullName fname sname =
    $"{fname} {sname}"
  let fullName = makeFullName "Frank" "Schmidt"
  $"Greetings {fullName} from {person}"
```

##### Accessing outer scoped values

If you declare a symbol before a nested scope, you can access it from within the nested scope:

```fsharp
let greetingTextWithFunction =
  let city = "London"                               // declares symbol in outer scope
  let makeFullName fname sname =
    $"{fname} {sname} from {city}"                  // accesses city within inner scope (closure)
  let fullName = makeFullName "Frank" "Schmidt"
  let surnameCity = $"{sname} from {city}"
  $"Greetings {fullName}"
```

##### Cyclical dependencies

Except in advanced scenarios, F# does not allow you to reference a symbol unless you've already declared it:

```fsharp
let description = $"{employee} lives in New York"       // Error: employee not yet defined
let employee = "Joe Bloggs"        
```

In short, F# requires all symbols to be defined before use. This ensures non-circular dependencies.

### 3.2 Type Inference

The general idea behind type inference: instead of you having to tell the compiler the type of every symbol (remember that F# is statically typed), the compiler should be able to figure it out for you.

#### 3.2.1 Benefits of type inference

Benefits:
- Easier to read&mdash;there's less extraneous code.
- Quicker to write&mdash;you type less while you're writing, allowing the compiler to deduce what you're doing.
- Quicker to refactor&mdash;you can make changes without having to make boilerplate changes throughout.

C# uses the `var` keyword for type inference.

#### 3.2.2 Type inference basics

```fsharp
let i = 10          // No type annotation
let i:int = 10      // Type annotation
```
In F#, a type annotation goes after the symbol name. Most newer programming languages (e.g. Go, Rust, TypeScript, Kotlin) follow this pattern. Older programming languages (e.g. Java, JavaScript, C#, C++) use the type before the symbol name.

In VS Code, the following setting enables type annotations: `"FSharp.inlayHints.typeAnnotations": true,`

<img src='images/1747642480805.png' width='400'/>

You can also also use the following setting to have type annotations appear after the statement: `"FSharp.lineLens.enabled": "replaceCodeLens"`

<img src='images/1747642665231.png' width='400'/>

```fsharp
let add (a:int) (b:int) : int =     // three explicit type annotations: the two function arguments and the return value
    let answer : int = a + b        // a fourth type annotation
    answer
```
**Note:** Parenthesis are required when making explicit type annotations for parameters.

<br>

**Exercise 3.2:** Complete the following steps to see some basic type inference in action:

1. Enter the code from listing 3.4 into an empty F# script file. 

```fsharp
let add (a: int) (b: int) : int =
    let answer: int = a + b
    answer
```

2. Observe that the CodeLens correctly identifies the type signature of the add function. 

<img src='images/20250617035424.png' width='450'/>

3. Remove the return type annotation (: int) so that the function declaration is let add (a:int) (b:int)

```fsharp
let add (a: int) (b: int) =
    let answer: int = a + b
    answer
```

4. Observe that the CodeLens still correctly indicates that the function returns an integer. 

<img src='images/20250617035550.png' width='250'/>

5. Remove the type annotation from answer. 

```fsharp
let add (a: int) (b: int) =
    let answer = a + b
    answer
```

6. Observe that the CodeLens still correctly understands that the function returns an integer. 

<img src='images/20250617035721.png' width='250'/>

7. Remove the type annotation from b (you can also remove the parenthesis around it). 

```fsharp
let add (a: int) b =
    let answer = a + b
    answer
```
8. Observe that the CodeLens still correctly understands that b is an integer. 

<img src='images/20250617035807.png' width='250'/>

9.  Remove the type annotation from a (you can also remove the parenthesis around it). 

```fsharp
let add a b =
    let answer = a + b
    answer
```
10. Observe that the CodeLens still correctly understands that a is an integer.

<img src='images/20250617035919.png' width='250'/>

The compiler assumes `a` and `b` are integers because `int` is the default for numeric operations in F#. If you had annotated one of the elements as a string, which still supports the `+` operator, the compiler would have inferred that both `a` and `b` are strings.

<img src='images/20250617040552.png' width='300'/>

In function declarations, why do you need parentheses around a parameter that uses type annotations?

```fsharp
let add a (b: int) : int =
```

To avoid ambiguity during parsing. If you wrote it like this:

```fsharp
let add a b: int = 
```

F# would interpret it incorrectly&mdash;as if you're assigning a return type to the function, not specifying the parameter type for `b`. It would be parsed as:

```fsharp
let add (a) (b) : int =
```

<br>

**Exercise 3.3:** 

1. Add the string hello to a + b on line 3. What happens? 

```fsharp
let add a b =
    let answer = a + b + "Hello"
    answer
```
The compiler now infers that `a` and `b` are both strings, because the `+` operator is being used with a string.

<img src='images/20250617041848.png' width='350'/>

2. Add a type annotation of string to the return type of the function. What happens? 

```fsharp
let add a b : string =
    let answer = a + b
    answer
```
<img src='images/20250617042452.png' width='250'/>

3. Explicitly annotate b as an integer again and add 13.34 (which is a float, not an int) to a + b on line 3. What happens?

```fsharp
let add a (b:int) : string =
    let answer = a + b + 13.34
    answer
```

Compiler error:  
<img src='images/20250617042319.png' width='700'/>

<br>

#### 3.2.3 Inferring generics

Generics allow you to create types and functions that can operate on any type rather than being bound to a specific concrete type.

```fsharp
let explicit = ResizeArray<int>()       // Creates a resizable array of ints with an explicit generic type argument
let typeHole = ResizeArray<_>()         // Creates a resizable array of ints using the underscore as a typeHole
let omitted = ResizeArray()             // Creates a resizable array of ints omitting the generic argument completely

typeHole.Add 99                         // typeHole now becomes ResizeArray<int>
omitted.Add 10
```

The typehole is represented by an underscore (_) and acts as a placeholder that tells the compiler "figure this out for me based on usage". It provides safe inference. Contrast this with the omitted generic argument, which is not type-safe and can lead to runtime errors.

**Exercise 3.4:** Change the value 10 to a string. What happens to the type of omitted? Note that if the compiler can’t infer the generic type argument because there’s no usage of the list, it will infer the type argument as Object, although the compiler will actually throw an error forcing you to add type annotations.

```fsharp
let explicit = ResizeArray<int>()
let typeHole = ResizeArray<_>()
let omitted = ResizeArray()

typeHole.Add 99
omitted.Add "this is a string"
```

The type of `ommitted` becomes `ResizeArray<string>`:

<img src='images/20250618034843.png' width='350'/>

##### Automatic Generalization

If F# determines an argument to a function is generic, it will automatically generalize your functions.

```fsharp
let combineElements<'T> (a:'T) (b:'T) (c:'T) =      // Specifies a generic type parameter 'T on the function
    let output = ResizeArray<'T>()                  // Creates a resize array of type 'T
    output.Add a
    output.Add b
    output.Add c
    output

combineElements<int> 1 2 3                          // Calls the function to combine three numbers
```
**Note:** The single quote before the type parameter `'T` is F# syntax to denote a type variable&mdash;a placeholder for a type that will be inferred later.

Automatic generalization means that you can do away with all type annotations and let the compiler infer the types for you:

```fsharp
let combineElements a b c =                         // Lets the compiler generalize the function for us
    let output = ResizeArray()
    output.Add a
    output.Add b
    output.Add c
    output

combineElements 1 2 3                               // Calls the automatically generalized function
```
The author recommends letting the compiler automatically generalize your functions, as it will infer the types based on usage. On the rare occasion, you can add explicit type annotations as needed.

#### 3.2.4 Diagnosing unexpected type inference

Consider the following two functions:

```fsharp
let calculateGroup age =                                // Has the signature int -> string
    if age < 18 then "Child"
    elif age < 65 then "Adult"
    else "Pensioner"

let sayHello someValue =                                // Has the signature float -> string
    let group =                                         // The string result of calling calculateGroup
        if someValue < 10.0 then calculateGroup 15
        else calculateGroup 35
    "Hello " +  group

let result = sayHello 10.5
```
<img src='images/20250618042000.png' width='500'/>

**Output:**

```cmd
> # 1 @"LocalCode\LearningDotNet\Books\fsharp_in_action\ch03\DiagnosingInferenceBehavior.fsx"
- let calculateGroup age =
-     if age < 18 then "Child"
-     elif age < 65 then "Adult"
-     else "Pensioner"
-
- let sayHello someValue =
-     let group =
-         if someValue < 10.0 then calculateGroup 15
-         else calculateGroup 35
-     "Hello " +  group
-
- let result = sayHello 10.5;;
val calculateGroup: age: int -> string
val sayHello: someValue: float -> string
val result: string = "Hello Adult"
```

Note how the type inference engine correctly figures out all the types for the functions.

If you change `18` to `"test"` in the `calculateGroup` function, the compiler will generate a number of errors:

<img src='images/20250618044110.png' width='950'/>

Note how the function signature for `calculateGroup` has changed to `string -> string`, which is not what we want. The compiler has inferred that the type of `age` is a string, which is incorrect.

The F# compiler uses the first opportunity it gets to infer the type of a value. 

You can guide the compiler by temporarily putting an explicit integer type annotation against `age`:

```fsharp
let calculateGroup (age:int) =
    if age < "test" then "Child"
    elif age < 65 then "Adult"
    else "Pensioner"
```
In this case, the compiler correctly shows a compiler error on the comparison test:

<img src='images/20250618044558.png' width='950'/>

#### 3.2.5 Limitations of type inference

There are a few areas where type inference doesn't work, and you'll have to use explicit type annotations. These cases are around the object-oriented features of F#. So, any classes you create or refrence from C# won't be inferred based on member access. This includes essentially all of the framework class library.

Once the compiler has identified a type, it can use that information for inference further downstream:

```fsharp
let addThreeDays (theDate:System.DateTime) =            // Type annotation required for the DateTime type
    theDate.AddDays 3

let addAYearAndThreeDays theDate =                      // Type annotation note required
    let threeDaysForward = addThreeDays theDate         // Usage point for type inference
    theDate.AddYears 
```

#### 3.2.6 Criticisms of type inference

The most commmon criticisms of type inference are:
1. It's "magic"
2. One can't determine the type of a variable without an annotation
3. You lose semantic meaning without an annotation (i.e. you can't easily see the intent or meaning of code without types)

The compiler doesn't guess types but instead uses a clearly defined set of precedence rules. All the issues with type inference can be followed through until one point in your codebase where a type clashes and leads to a compiler error.

Modern IDEs give both tooltips or a code lens that shows the type of a symbol, so you can easily see what the type is without having to add an annotation.

The following code conveys the intent of the code without needing to add type annotations:

```fsharp
let x = getData()                                       // No type annotations, poor naming
let x:Customer list = getData()                         // Type annotation, poor naming
let customersToRemind = loadOverDueCustomers()          // No type annotations, good naming
```

The author advises not to bother with type annotations. 

Type inference fits with the "more with less" philosophy of F# and the idea of trusting the compiler to do its job. Type inference is incredibly useful in writing succinct, easily rfactorable code without needing a third-party tool to rewrite your code for you.

## 4. F# Fundamentals

Two core features of F# will have a large effect on how you write and design code:  expressions and immutability.

Both features go hand-in-hand: without one, the other woudn't be especially useful. 

Both are designed to change the way you write code into one that's oriented around working with values and applying transformations to those values as the basic mechanism of implementing logic.

### 4.1 Expressions

Expressions vs. Statements

|             | Returns Something? | Has side-effects? |
| ----------- | ------------------ | ----------------- |
| Expressions | Always             | Occassionally     |
| Statements  | Never              | Always            |

#### 4.1.1 Purity and side effects

**Purity**

A *pure* function is a function that doesn't have any side effects and is guaranteed to always give the same output for a given input.

Pure functions are easy to test; you only have to worry about giving it some inputs and checking the return value. You don't have to check whether some internal, encapsulated state has been modified or a file has been written; it's just inputs and outputs.

Some functional programming languages, such as Haskell, enforce functional purity. F# doesn't provide any gurantees over pure functions, but it does have some features to help you identify functions that are not pure.

**Side Effect**  

A side effect is typically some effect that a function has on data that exists outside of itself. This could be writing to a database table, printing to the console, getting the current date or time, or modifying some global mutable state. 

Side effects can't be observed from a function's signature (i.e. its inputs or outputs) and so can be harder to test. Instead, you may need to observe side effects by calling other methods on an object and confirming that its behavior has changed or looking to see if a row was added to a database table.

**Exercise 4.1**

Let’s look at some simple examples of statements and expressions. Which of the following do you think is which? 

1. A method on an Employee class, SetSalary(), that takes in their new salary and modifies its private state to the new salary. It returns nothing (known as void in some languages).  - Statement

2. A function Add, which takes in two numbers and returns the sum of them. - Expression

3. A function SaveCustomer, which takes in a customer and saves it to a database. The function returns nothing.  - Statement

4. A function SaveCustomer, which takes in a customer and saves it to a database. The function returns true if it succeeded and false if the customer already exists. - Statement (Wrong!)

**Answers:** 

Answers 1 and 3 are statements: they run some code and change some state somewhere but return nothing. The only way that they can affect the application is by modifying some state or calling external systems. It’s impossible to know their output from the type signature since both return nothing (in some languages, this is known as void). Answers 2 and 4 are expressions: both take in some values and give back something in return.

#### 4.1.2 Difficulties with statements

Object-oriented languages are *statement-oriented*: the primary way you compose code is through statements and functions, which behave as statements.

There are several issues with statements that allow bugs to creep in.

Example:

```csharp
using System;

public void DescribeAge(int age) {
    string ageDescription = null;               // Initializes a variable with a default value
    var greeting = "Hello";                     // Creates a variable to use later
    if (age < 18)
    {
        ageDescription = "Child";               // First if branch
    }
    else if (age < 65)                          // Second if branch
    {
        greeting = "Adult";
    }
    Console.WriteLine($"{greeting}! You are a '{ageDescription}'.");
}
```

**Issues:**

- There's no handler for the case when age >= 65. The code will print out `null` for the description.
- The code accidentally assigned the string to `greeting` rather than `ageDescription`, in the second case.
- `ageDescription` needed to be declared with a default value before assigning it. This opens the possibility of bugs for complicated logic.

**Note:** Updates to languages, like C#, have non-nullable reference types, which makes it possible to create values that can never be set to `null`.

In the above code, you may be quick to say that no one really makes mistakes like this, but as code base grows, people make mistakes like this all the time.

#### 4.1.3 Expressions to the rescue

The above code is perfectly valid from the compiler's perspective yet contains mistakes. So, why can't the compiler fix these things for you?

The answer is that statements are weak. Compilers have no understanding that there's any relationship between the branches of the `if/else` block; instead, they're just different paths to execute.

What we need is a more powerful construct for the compiler to understand: expressions.

```csharp
using System;

private static string GetDescription(int age) {         // Expression with signature int -> string
    if (age < 18) return "Child!";
    else if (age < 65) return "Adult!";
    else return "OAP!";
}

public void DescribeAge(int age) {
    var ageDescription = GetDescription(age);           // Call site to function
    var greeting = "Hello";
    Console.WriteLine($"{greeting}! You are a '{ageDescription}'.");
}
```

**Improvements**:

- It's now impossible to forget to include the `else` clause when generating the description; if you do, the compiler will give you an error.
- You can't accidentally assign the description to the wrong variable because the assignment to `ageDescription` is performed in only one location.
- You don't need to create an arbitrary default view for your variables.

There's now a clear separation between working with data transformations and assigning the result to a variable (`ageDescription`).

The mixing of calculations and assignments is something you should avoid, as it leads to bugs. You'll see this distinction time and time again in F#&mdash;series of data transformations followed by a final state modifiction.

#### 4.1.4 Expressions in F#

F# is an expression-oriented language. Virtually everything is an expression; there are no statements or functions that return `void` (although there is a nifty escape hatch for cases wher8you don't have any result).

You don't need the `return` keyword in F#: since every scope of code must return something, the `return` keyword isn't needed.

Even `if/then` branching logic constructs are expressions.

```fsharp
let describeAge age =
    let ageDescription =                    // As an expression, each branch of `if/then` must return the same type.
        if age < 18 then "Child"
        elif age < 65 then "Adult"
        else "OAP"
    let greeting = "Hello"
    $"{greeting}! You are a '{ageDescription}'."
```

With this method, you don't have to create arbitrary methods or functions to benefit from the extra safety that expressions provide; they're baked into the language.

Also, this sample no longer relies on modifying (mutating) any data: `ageDescription` and greeting are never modified; they are only set once.

Lastly, the function just returns a string instead of printing to the console. This makes the overall function an expression as it now returns a string. If you had printed it out, it would have returned a `unit`.

#### 4.1.5 Composability

Another benefit of expressions is that they naturally compose, meaning they tend to create more flexible codebases that you can more easily refactor or repurpose later on without much effort.

Consider introducing the support of writing to a disk rather than printing to the console. If you separate the method into two parts, one that generates a string and another that outputs to the console, you can reuse the first part much more easily (as well making unit testing simpler).

```csharp
using System;
public void DescribeAge(int age)
{
    string ageDescription = null;
    var greeting = "Hello";
    if (age < 18)
        ageDescription = "Child";
    else if (age < 65)
        greeting = "Adult";
    Console.WriteLine($"{greeting}! You are a '{ageDescription}'.");
}
```

##### Refactoring to functions

Let's take a practical look at how to refactor the following code so that it calculates the `ageDescription` in its own function rather than a nested scope, so we can easily use it with other outputs, such as the file system.

```fsharp
let describeAge age =
    let ageDescription =                    
        if age < 18 then "Child"
        elif age < 65 then "Adult"
        else "OAP"
    let greeting = "Hello"
    $"{greeting}! You are a '{ageDescription}'."
```
**Note:** this is a common practice in F#.

**Exercise 4.2:**
 
1. Identify the scope you wish to move into a function of its own.

```fsharp
        if age < 18 then "Child"
        elif age < 65 then "Adult"
        else "OAP"
```

2. Cut the code and paste it above the function that it's currently in, taking care to correct indentation.

```fsharp
    if age < 18 then "Child"
    elif age < 65 then "Adult"
    else "OAP"

let describeAge age =
    let ageDescription =                    
    let greeting = "Hello"
    $"{greeting}! You are a '{ageDescription}'."
```

3. Identify any required symbols and add them as inputs to the function. For example, in listing 4.3, this is the `age` symbol. Don’t worry about type annotations; the compiler can normally infer them for you.

```fsharp
let ageDescription age                      // Note: I missed the `=`. Also, should rename the function to indicate an action.
    if age < 18 then "Child"
    elif age < 65 then "Adult"
    else "OAP"

let describeAge age =
    let ageDescription =                    
    let greeting = "Hello"
    $"{greeting}! You are a '{ageDescription}'."
```

4. In place of the code in the original function, replace it with a call to the newly created function.

```csharp
let ageDescription age
    if age < 18 then "Child"
    elif age < 65 then "Adult"
    else "OAP"

let describeAge age =
    let ageDescription = ageDescription(age)         // Wrong syntax for function call        
    let greeting = "Hello"
    $"{greeting}! You are a '{ageDescription}'."
```

The book's answer:

```fsharp
open System

let calculateAgeDescription age =
    if age < 18 then "Child"
    elif age < 65 then "Adult"
    else "OAP"

let describeAge age =
    let ageDescription = calculateAgeDescription age
    let greeting = "Hello"
    printfn $"{greeting}! You are a '{ageDescription}'."
```

#### 4.1.6 Unit

F# insists that every function you create returns something. So, how do you handle cases where code doesn't return any value, e.g. a function whose result is simply to print something to the console?

The answer: F# has a built-in value called `unit` that represents nothing. However, unlike `void` in other languages, `unit` acts like a regular value that can be returned from any piece of code or even bound to a symbol.

```fsharp
let printAddition a b =
    let answer = a + b
    printfn $"{a} plus {b} is {answer}."            // The function result is a unit
```

**Interoperating with void**

When interoperating with the .NET Framework Class Library (FCL), there are thousands of methods that return `void`. F# implicitly converts `unit` to `void`, so anywhere there are code listings that return `void`, it'll be represented in F# as `unit`, and vice versa.


Note how the code lens signatures indicates a return type of `unit`:  

<img src="images/1752655022812.png" width="450"/>

##### Unit as an input

You can also use `unit` as an input to a function. This is useful to have some code that is executed every single time it is called.

In the following code, `getCurrentTime` always returns its initial value; it doesn't recalculate itself once it's been bound.

```fsharp
let getTheCurrentTime = System.DateTime.Now         // Calculates the current time and assigns it to a symbol
let x = getTheCurrentTime                           // Copies the value of getCurrentTime to another symbol
let y = getTheCurrentTime                           // Copies the value of getCurrentTime to another symbol
```
However, if you change the definition to take `unit` as input, signified by `()`, this behavior changes:

```fsharp
let getTheCurrentTime () = System.DateTime.Now      // Creates a function that returns the current time
let x = getTheCurrentTime ()                        // Calls a function and assigns the current time to a symbol
let y = getTheCurrentTime ()                        // Calls a function and assigns the current time to a symbol
```
Think of this as telling the F# compiler that every time you call this piece of code, the state of the world has changed, and therefore it should re-evaluate the function.

##### Unit and side effects

Seeing `unit` in a function signature, either as input or as output, is a tell-tale sign that this function has some kind of side effect, in that calling it multiple times will probably yield different results every time.

- *`Unit` as input*: Probably calling some impure code that will affect the result, e.g. getting the current time, generating a random number.
- *`Unit` as output*: Probably writing to some I/O as the final action in the body, e.g. print to console, write to filesystem, save to database.

However, since F# doesn't enforce purity, it's still possible that code that doesn't take in or return `unit` still has a side effect.

```fsharp
let addDays days =                                                      // Function has signature float -> System.DateTime
    let newDays = System.DateTime.Today.AddDays days                    // Invisible side effect: it gets the current date
    printfn $"You gave me {days} days and I gave you {newDays}."        // Invisible side effect: it prints to the console
    newDays
let result = addDays 3
```

#### 4.1.7 Ignore

There are times when you call a function that returns a value you're not interested in. This is common with functions like `addDays` above that have some side effect (printing to the console) but return a value you don't care about.

Let's assume we're only interested in calling `addDays` for its ability to print to the console. We're not interested in its return value, and we write the following code:

```fsharp
let addSeveralDays () =         // Defines a function that takes unit as input
    addDays 1                   // Calls addDays several times and implicitly ignores the outputs
    addDays 2
    addDays 3                   // Final call: the result from this call is returned back out
```
F# provides a warning for the first two calls:

<img src="images/1752656878056.png" width=1000 />

Warning message:
`The result of this expression has type 'DateTime' and is implicitly ignored. Consider using 'ignore' to discard this value explicitly, e.g. 'expr |> ignore', or 'let' to bind the result to a name, e.g. 'let result = expr'.`

Why are we getting this warning? 

Remember that F# is an expression-oriented language, and in such a language, you compose code by plugging together functions that take in some data and return a result, which can be acted on by another piece of code. So, throwing away the result of a function makes no sense. That is unless your code executes some side effect that the compiler is unaware of (as in the case of `addDays`).

In this case, you need to tell F# that this function returns something, but you know better and are happy to ignore the result. This is done by using the built-in function `ignore`:

```fsharp
let addSeveralDays () =
    ignore (addDays 3)      // Explicitly ignores the result of addDays
    ignore (addDays 5)
    addDays 7
```

`ignore` takes in any value and gives back a `unit` value, which the F# compiler understands can be discarded without a warning.

<img src="images/1752657710521.png" width=225 />

**Creating statements in F#**  
While atypical, you can do statement-based evaluation in F#. Essentially, just make sure that all of your code returns `unit` (using `ignore` where necessary). In addition, you'll need to use mutable data throughout your codebase, which is deliberately more work than using *immutable* data.

### 4.2 Immutable Data

If expressions are the one part of the core of how you architect and organize code in F#, immutability is the other half. Immutability is almost mandatory once you accept that you want to develop using expressions.

#### 4.2.1 The problem with mutability

Immutability is the concept of working with data that never changes. You create data with a value, and that value is set for the lifetime of a symbol.

Realword issues of working with mutable data:

**The unrepeatable bug**

Applications that use a shared mutable state stored in the middle can cause bugs that are difficult to reproduce.

**Multithreading pitfalls**

When using multithreading, race conditions that only occur under a specific load and a certain ordering of messages. 

**Accidentally sharing state**

You designed a business object class, while your colleague has written code to operate on that object. You call their code, supplying an appropriate object. Some time later, a bug arises: the state of the business object no longer looks as it did previously! It turns out the code your colleague wrote modified a property on the object without you realizing it. You made the property public only so thatyou could change it; you didn't intend or expect other areas of code to modify it. You fix the problem by making an interface for the type that exposes the bits that are really public on the type and give it to the consumers instead.

**Testing hidden state**

You're writing unit tests. You want to test a branch of a specific method on your class, but you first need to get the object into a particular state by calling other methods on the class.

You mock out the dependencies required by these other methods and then try to assess whether your actual method under test worked as expected. However, you only then realize the only way to do this is to access some private state of the class, which is not visible to your unit test, so you simply change the accessibility of the private field to public.

**Summary**

The single truth: working with mutable data is hard. It's hard to reason about the lifetime of data, and changes of state can happen in ways that are hard to trace or predict, especially in complex systems.

The problem is we simply assume that mutability is a way of life, something we can't escape. So we look for other ways around these sorts of issues, including encapsulation, hacks, or design patterns that add more code, effort, and complexity. 

It turns out that working with immutable data solves many of these issues.

#### 4.2.2 Modeling with mutable and immutable data

Working with mutable structures in the object-oriented world follows a simple model: you create an object and then modify its state through operations on that object. 

<img src="images/1752743680801.png" alt="alt text" width="400"/>

What's tricky about this model is it can be hard to reason about your code: calling a method such as `UpdateState()` will generally have no return value; the result of calling the method is a *side effect* that takes place internally on the object on some encapsulated state.

In the immutable world, you cannot modify any data. Instead, every time you want to apply an operation, you create a new copy of the data with any updates applied to that, which is then given back to the caller. That state becomes the new, current state, which is passed downstream.

<img src="images/1752743900036.png" alt="alt text" width="200"/>

Every call to `GenerateNewState()` creates a new object rather than modifying a single item.

**Performance of immutable data**

A common but nearly always unsubstantiated concern of immutable data is that it must be slow. After all, we're creating copies of data rather than making changes to a single version, right?

The author's advice: unless you can back up that concerns with real evidence, then don't worry about it. The author's experience is you simply won't notice any difference except for very specific use cases.

Yes, it does involve more work to create a copy of the data rather than making an in-place update to it. However, unless you're in a tight loop performing millions of updates per second, the cost of doing so is negligible compared to, say, opening a database connection or deserializing some JSON data.

Many languages, including F#, also have data structures designed to work with immutable data in a highly efficient manner, as well as some compiler tricks to help keep garbage collection to a minimum.

#### 4.2.3 Optimizing and opinionated languages

All languages are opinionated and optimized in some way. F# is optimized for working with immutable data. While F# can work with mutable data, the syntax is more verbose than for immutable data. The inverse is true in other languages.

Here's the C# version:
```csharp
const string name = "isaac";                // Immutable data in C#
var age = 42;                               // Declares a mutable variable
age = 43;                                   // Performs an assignment
if (age == 43) {...}                        // Performs an  expression
```
Here's the F# version:
```fsharp
let name = "isaac"                          // Declares an immutable value
let mutable age = 42                        // Declares a mutable variable
age <- 43                                   // Performs an assignment
if age = 43 then ...                        // Performs a comparison
```

Things to note:
- F# optimizes for creating immutable data: it's less code to write than for mutable data, where you need an extra keyword.
- F# optimizes for working with immutable data: when it comes to the equality comparison, the equals symbol `=` is used for equality checks, and the new operator `<-` is used for mutation/assignment. In C#, `=` is used for assignment and `==` is used for equality checks. 

##### Working with immutable data: a worked example

In this scenario, we model a car with both mutable and immutable data&mdash;code that can simulate the gas tank in a car.

- A function called `drive` that takes the distance driven as input, which is a string of either `far`, `medium`, or `near`.
- The gas tank starts at `100`.
- If driving far, reduce the amount of gas by half in the gas tank.
- If driving medium, reduce the amount by 10.
- Otherwise, reduce the amount by 1.

**Mutable version:**

```fsharp
let mutable gas = 100.0                                 // Creates a mutable variable and sets its value to a float
let drive distance =                                    // Creates a function that is dependent on the mutable state
    if distance = "far" then gas <- gas / 2.0           // Mutates using the <- operator
    elif distance = "medium" then gas <- gas - 10.0     // Mutates using the <- operator
    else gas <- gas - 1.0                               // Mutates using the <- operator
```

Things to note:

1. Look at the type signature of the `drive` function. It's dishonest in two ways:

<img src="images/1752826967230.png" width="400"/>  

- It's dependent on two pieces of data, but only one is shown as an input. `gas` is implicitly utilized, but you can't see that from the type signature. This is similar to a method on a class that uses some encapsulated private state.
- `drive` has no outputs. You call it, and it silently modifies the mutable `gas` variable; you can't know this from the type signature, which returns `unit`.

2. Methods are nondeterministic. You can't know the behavior of a method without knowing the state. If you call `drive "far"` three times, the value of `gas` will change every time by a different amount, depending on the previous calls.

3. You have no control over the ordering of method calls. If you switch the order of calls to `drive` you'll get a different answer at the end.

```cmd
> # 1 @"...\LearningDotNet\Books\fsharp_in_action\ch04\mutable_car.fsx"
- let mutable gas = 100.0
- let drive distance =
-     if distance = "far" then gas <- gas / 2.0
-     elif distance = "medium" then gas <- gas - 10.0
-     else gas <- gas - 1.;;
val mutable gas: float = 100.0
val drive: distance: string -> unit

> # 7 @"...\LearningDotNet\Books\fsharp_in_action\ch04\mutable_car.fsx"
- drive "far";;
val it: unit = ()

> drive "near";;
val it: unit = ()

> drive "far";;
val it: unit = ()

> drive "medium";;
val it: unit = ()

> gas;;
val it: float = 14.5
```

**Immutable version:**

```fsharp
let drive gas distance =                            // Function is explicitly dependent on the state
    if distance = "far" then gas / 2.0
    elif distance = "medium" then gas - 10.0
    else gas - 1.0

let gas = 100.0                                     // Stores the initial start date
let firstState = drive gas "far"                    // Stores the result of each function call in a separate symbol
let secondState =  drive firstState "medium"
let thirdState = drive secondState "near"           // Manually chains calls together
```
<img src="images/1752828136362.png" alt="alt text" width="350"/>

Important change:

There is no longer a mutable version of `gas`, but an initial state of `100` and then a set of immutable values threaded through each function call. There are several benefits to this:
- You can reason about the behavior easily. The function is "honest" and easily understandable from the type signature: the function takes in `gas` and `distance` and returns the updated `gas`.
- Rather than hidden side effects on private fields, each method or function call returns a new version of the state that you can easily understand.
- Function calls are repeatable. You can `drive 50 "far"` as many times as you want and get the same result each time. This is because the only values that can affect the result are the inputs to the function; there's no global state that is implicitly used&mdash;in other words, a pure function.
- The compiler can protect you from accidentally misordering function calls because each function call is explicitly dependent on the output of the previous call.
- You can also see the value of each intermediate step as you work up toward the final state.

In the above code, we manually stored the intermediate state and explicitly passed it to the next function call in the chain. This is not necessary in F#. The author will later show how F# has syntax designed specifically to avoid this behavior.

#### 4.2.4 Other benefits of immutable data

- Encapsulation is no longer as important: since everything is read-only, you don't have to live in fear that some other part of the code will pull the rug underneath you and change the value of your data. While encapsulation is useful to have (i.e. as part of a public API), and F# has modifiers such as `public`, `private`, and `internal`, making your data read-only eliminates the need to hide data values.
- You don't need to worry about locks within a multithreaded environment. Because there's no shared mutable state, you never have to be concerned with race conditions. Every thread can access the same piece of data as often as it likes, as it can never change.

## 5. Shaping Data






   
