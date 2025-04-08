# F# In Action
<img src='images/20250408025735.png' width='250'/>

Resources
- [Book Code](https://github.com/isaacabraham/fsharp-in-action)

Helpful Commands
```cmd
# Create a new F# project
dotnet new console -lang F# -o HelloFSharp
dotnet new sln --name HelloFSharp
dotnet sln add HelloFSharp
```


Mental model of the F# process

<img src='images/20250408025610.png' width='450'/>

## Imperative Code

**The what, not how**

Is how you implement something, and typically includes a set of lower-level
instructions. Declarative code concentrates on what you want to achieve, leaving
the low-level details to the compiler.

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
