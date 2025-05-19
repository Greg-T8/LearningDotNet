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
**Note:**  
- Parenthesis are required when making explicit type annotations for parameters.

**Exercise 3.2:**

