let combineElements<'T> (a:'T) (b:'T) (c:'T) =
    let output = ResizeArray<'T>()
    output.Add a
    output.Add b
    output.Add c
    output

combineElements<int> 1 2 3