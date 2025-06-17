let explicit = ResizeArray<int>()       // Creates a resizable array of ints with an explicit generic type argument
let typeHole = ResizeArray<_>()         // Creates a resizable array of ints using the underscore as a typeHole
let omitted = ResizeArray()             // Creates a resizable array of ints omitting the generic argument completely

typeHole.Add 99
omitted.Add 10
