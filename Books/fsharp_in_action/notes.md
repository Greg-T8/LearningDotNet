# F# In Action
<img src='images/20250408025735.png' width='250'/>

<details>

<summary>Book Resources</summary>

- [Book Code](https://github.com/isaacabraham/fsharp-in-action)
</details>

## DotNet Commands
```cmd
# Create a new solution
dotnet new sln --name HelloFSharp

# Create a new F# project
dotnet new console -lang F# -o HelloFSharp

# Add the project to the solution
dotnet sln add HelloFSharp
```

## Introduction to F#
<details>
<summary>About F# and Functional Programming</summary>

**F# Mental Model**

<img src='images/20250408025610.png' width='450'/>

**Imperative Code vs Declarative Code**

We are used to writing imperative code. F# is a functional-first language, which uses declarative code. According to the author, "if you're used to imperative model of developing, it can feel like giving up control. However, once you're used to [functional programming], it's very difficult to go back."

- Imperative code - the low-level "how", which focuses on step-by-step instructions.
- Declarative code - the high-level "what", which focuses on the end result, leaving the low-level details to the compiler

<img src='images/20250408030753.png' width='400'/>

In the example above, the imperative version takes ownership of *how* we want to
filter the numbers&mdash;by creating an intermediary list, iterating through
each one, etc.

**Composability**

Functions are the main component of F# programs, rather than classes. F#
emphasizes composition over inheritance, which is a common theme in functional
programming. This means that you can build complex functions by combining
simpler ones, rather than relying on a rigid class hierarchy.

<img src='images/20250408031523.png' width='400'/>

**Data and behavior**

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

**A smarter compiler** 

F# inevitably changes how you write code. F# helps a great deal in reducing
boilerplate activities.

F# encourages a safer, more deliberate coding style by making it impossible to
ignore changes to your types—your code won’t compile until every usage is
updated. This eliminates a whole class of bugs (like null reference exceptions)
*at compile time* without relying on unit tests. The result is fewer runtime
surprises and less debugging, all thanks to the compiler doing more of the work
for you.

**F# and .NET**

- You can reference any .NET assembly from F#
- You can consume and create classes with inheritance, interfaces, properties, and methods
- F# permits you to mix both FP and OO styles

<img src='images/20250418034314.png' width='300'/>

</details>

### Hello World

```fsharp
let name = "Greg"
let time = System.DateTime.UtcNow
printfn $"Hello from F#! My name is {name}, the time is {time}"
```

See [HelloFSharp](./Books/fsharp_in_action/HelloFSharp) for the code.